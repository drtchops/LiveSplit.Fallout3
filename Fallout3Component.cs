using LiveSplit.Model;
using LiveSplit.TimeFormatters;
using LiveSplit.UI.Components;
using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;

namespace LiveSplit.Fallout3
{
    class Fallout3Component : LogicComponent
    {
        public override string ComponentName
        {
            get { return "Fallout 3"; }
        }

        public Fallout3Settings Settings { get; set; }

        public bool Disposed { get; private set; }
        public bool IsLayoutComponent { get; private set; }

        private TimerModel _timer;
        private GameMemory _gameMemory;
        private LiveSplitState _state;

        public Fallout3Component(LiveSplitState state, bool isLayoutComponent)
        {
            _state = state;
            this.IsLayoutComponent = isLayoutComponent;

            this.Settings = new Fallout3Settings();

            _timer = new TimerModel { CurrentState = state };

            _gameMemory = new GameMemory();
            _gameMemory.OnFirstLevelLoading += gameMemory_OnFirstLevelLoading;
            _gameMemory.OnPlayerGainedControl += gameMemory_OnPlayerGainedControl;
            _gameMemory.OnLoadStarted += gameMemory_OnLoadStarted;
            _gameMemory.OnLoadFinished += gameMemory_OnLoadFinished;
            _gameMemory.OnSplitCompleted += gameMemory_OnSplitCompleted;
            state.OnReset += state_OnReset;
            _gameMemory.StartMonitoring();
        }

        public override void Dispose()
        {
            this.Disposed = true;

            _state.OnReset -= state_OnReset;

            if (_gameMemory != null)
            {
                _gameMemory.Stop();
            }
        }

        void state_OnReset(object sender, TimerPhase e)
        {
            _gameMemory.resetSplitStates();
        }

        void gameMemory_OnFirstLevelLoading(object sender, EventArgs e)
        {
            if (this.Settings.AutoStart)
            {
                _timer.Reset();
            }
        }

        void gameMemory_OnPlayerGainedControl(object sender, EventArgs e)
        {
            if (this.Settings.AutoStart)
            {
                _timer.Start();
            }
        }

        void gameMemory_OnLoadStarted(object sender, EventArgs e)
        {
            _state.IsGameTimePaused = true;
        }

        void gameMemory_OnLoadFinished(object sender, EventArgs e)
        {
            _state.IsGameTimePaused = false;
        }

        void gameMemory_OnSplitCompleted(object sender, GameMemory.SplitArea split, uint frame)
        {
            Trace.WriteLineIf(split != GameMemory.SplitArea.None, String.Format("[NoLoads] {0} Split - {1}", split, frame));
            if (!_gameMemory.splitStates[(int)split] &&
                ((split == GameMemory.SplitArea.SPECIAL && this.Settings.SPECIAL) ||
                (split == GameMemory.SplitArea.TargetPractice && this.Settings.TargetPractice) ||
                (split == GameMemory.SplitArea.Escape && this.Settings.Escape) ||
                (split == GameMemory.SplitArea.Walking && this.Settings.Walking) ||
                (split == GameMemory.SplitArea.Vault87 && this.Settings.Vault87) ||
                (split == GameMemory.SplitArea.Flashbang && this.Settings.Flashbang) ||
                (split == GameMemory.SplitArea.Escape2 && this.Settings.Escape2) ||
                (split == GameMemory.SplitArea.Walking2 && this.Settings.Walking2) ||
                (split == GameMemory.SplitArea.Memorial && this.Settings.Memorial)))
            {
                _timer.Split();
                _gameMemory.splitStates[(int)split] = true;
            }
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return this.Settings.GetSettings(document);
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return this.Settings;
        }

        public override void SetSettings(XmlNode settings)
        {
            this.Settings.SetSettings(settings);
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }
        public override void RenameComparison(string oldName, string newName) { }
    }
}
