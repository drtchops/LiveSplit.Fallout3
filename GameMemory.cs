using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSplit.Fallout3
{
    class GameMemory
    {
        public enum SplitArea : int
        {
            None,
            SPECIAL,
            TargetPractice,
            Escape,
            Walking,
            Vault87,
            Flashbang,
            Escape2,
            Walking2,
            Memorial,
        }

        public event EventHandler OnFirstLevelLoading;
        public event EventHandler OnPlayerGainedControl;
        public event EventHandler OnLoadStarted;
        public event EventHandler OnLoadFinished;
        public delegate void SplitCompletedEventHandler(object sender, SplitArea type, uint frame);
        public event SplitCompletedEventHandler OnSplitCompleted;

        private Task _thread;
        private CancellationTokenSource _cancelSource;
        private SynchronizationContext _uiThread;
        private List<int> _ignorePIDs;

        private DeepPointer _isLoadingPtr;
        // private DeepPointer _cellID;
        // private DeepPointer _world_XPtr;
        // private DeepPointer _world_YPtr;

        private enum Locations
        {
            Tamriel = 0x0000003C,
            Sovngarde = 0x0002EE41,
            HelgenKeep01 = 0x0005DE24,
        }

        private enum ExpectedDllSizes
        {
            Fallout3Steam = 27336704,
            Fallout3Cracked = 26771456,
        }

        public bool[] splitStates { get; set; }

        public void resetSplitStates()
        {
            for (int i = 0; i <= (int)SplitArea.Memorial; i++)
            {
                splitStates[i] = false;
            }
        }

        public GameMemory()
        {
            splitStates = new bool[(int)SplitArea.Memorial + 1];

            _isLoadingPtr = new DeepPointer(0x010746F8); // == 1 if a loadscreen is happening
            // _cellID = new DeepPointer(0x01738308, 0x4, 0x78, 0x670, 0xEC); // ID of the current cell
            // _world_XPtr = new DeepPointer(0x0172E864, 0x64); // X world position (cell)
            // _world_YPtr = new DeepPointer(0x0172E864, 0x68); // Y world position (cell)

            resetSplitStates();

            _ignorePIDs = new List<int>();
        }

        public void StartMonitoring()
        {
            if (_thread != null && _thread.Status == TaskStatus.Running)
            {
                throw new InvalidOperationException();
            }
            if (!(SynchronizationContext.Current is WindowsFormsSynchronizationContext))
            {
                throw new InvalidOperationException("SynchronizationContext.Current is not a UI thread.");
            }

            _uiThread = SynchronizationContext.Current;
            _cancelSource = new CancellationTokenSource();
            _thread = Task.Factory.StartNew(MemoryReadThread);
        }

        public void Stop()
        {
            if (_cancelSource == null || _thread == null || _thread.Status != TaskStatus.Running)
            {
                return;
            }

            _cancelSource.Cancel();
            _thread.Wait();
        }

        void MemoryReadThread()
        {
            Debug.WriteLine("[NoLoads] MemoryReadThread");

            while (!_cancelSource.IsCancellationRequested)
            {
                try
                {
                    Debug.WriteLine("[NoLoads] Waiting for Fallout3.exe...");

                    Process game;
                    while ((game = GetGameProcess()) == null)
                    {
                        Thread.Sleep(250);
                        if (_cancelSource.IsCancellationRequested)
                        {
                            return;
                        }
                    }

                    Debug.WriteLine("[NoLoads] Got Fallout3.exe!");

                    uint frameCounter = 0;

                    bool prevIsLoading = false;
                    // int prevCellID = 0;

                    bool loadingStarted = false;

                    while (!game.HasExited)
                    {
                        bool isLoading;
                        _isLoadingPtr.Deref(game, out isLoading);

                        // int cellID;
                        // _cellID.Deref(game, out cellID);
                        // int world_X;
                        // _world_XPtr.Deref(game, out world_X);
                        // int world_Y;
                        // _world_YPtr.Deref(game, out world_Y);

                        if (isLoading != prevIsLoading)
                        {
                            if (isLoading)
                            {
                                Debug.WriteLine(String.Format("[NoLoads] Load Start - {0}", frameCounter));

                                loadingStarted = true;

                                // pause game timer
                                _uiThread.Post(d =>
                                {
                                    if (this.OnLoadStarted != null)
                                    {
                                        this.OnLoadStarted(this, EventArgs.Empty);
                                    }
                                }, null);
                            }
                            else
                            {
                                Debug.WriteLine(String.Format("[NoLoads] Load End - {0}", frameCounter));

                                if (loadingStarted)
                                {
                                    loadingStarted = false;

                                    // unpause game timer
                                    _uiThread.Post(d =>
                                    {
                                        if (this.OnLoadFinished != null)
                                        {
                                            this.OnLoadFinished(this, EventArgs.Empty);
                                        }
                                    }, null);
                                }
                            }
                        }

                        // Debug.WriteLineIf(cellID != prevCellID, String.Format("[NoLoads] CellID changed from {0} to {1} - {2}", prevCellID.ToString("X8"), cellID.ToString("X8"), frameCounter));

                        prevIsLoading = isLoading;
                        // prevCellID = cellID;
                        frameCounter++;

                        Thread.Sleep(15);

                        if (_cancelSource.IsCancellationRequested)
                        {
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    Thread.Sleep(1000);
                }
            }
        }

        Process GetGameProcess()
        {
            Process game = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.ToLower() == "fallout3"
                && !p.HasExited && !_ignorePIDs.Contains(p.Id));
            if (game == null)
            {
                return null;
            }

            if (false && (game.MainModule.ModuleMemorySize != (int)ExpectedDllSizes.Fallout3Steam && game.MainModule.ModuleMemorySize != (int)ExpectedDllSizes.Fallout3Cracked))
            {
                _ignorePIDs.Add(game.Id);
                _uiThread.Send(d => MessageBox.Show("Unexpected game version. Fallout3 1.9.32.0.8 is required.", "LiveSplit.Fallout3",
                    MessageBoxButtons.OK, MessageBoxIcon.Error), null);
                return null;
            }

            return game;
        }
    }
}
