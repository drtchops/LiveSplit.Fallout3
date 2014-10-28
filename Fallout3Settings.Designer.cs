namespace LiveSplit.Fallout3
{
    partial class Fallout3Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbStartSplits = new System.Windows.Forms.GroupBox();
            this.tlpStartSplits = new System.Windows.Forms.TableLayoutPanel();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.gbEndSplits = new System.Windows.Forms.GroupBox();
            this.tlpEndSplits = new System.Windows.Forms.TableLayoutPanel();
            this.gbDisplayAlternateTiming = new System.Windows.Forms.GroupBox();
            this.tlpDisplayAlternateTiming = new System.Windows.Forms.TableLayoutPanel();
            this.chkDisplayWithoutLoads = new System.Windows.Forms.CheckBox();
            this.chkMemorial = new System.Windows.Forms.CheckBox();
            this.chkTargetPractice = new System.Windows.Forms.CheckBox();
            this.chkSPECIAL = new System.Windows.Forms.CheckBox();
            this.chkEscape = new System.Windows.Forms.CheckBox();
            this.chkWalking = new System.Windows.Forms.CheckBox();
            this.chkVault87 = new System.Windows.Forms.CheckBox();
            this.chkFlashbang = new System.Windows.Forms.CheckBox();
            this.chkEscape2 = new System.Windows.Forms.CheckBox();
            this.chkWalking2 = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.gbStartSplits.SuspendLayout();
            this.tlpStartSplits.SuspendLayout();
            this.gbEndSplits.SuspendLayout();
            this.tlpEndSplits.SuspendLayout();
            this.gbDisplayAlternateTiming.SuspendLayout();
            this.tlpDisplayAlternateTiming.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.gbStartSplits, 0, 0);
            this.tlpMain.Controls.Add(this.gbEndSplits, 0, 1);
            this.tlpMain.Controls.Add(this.gbDisplayAlternateTiming, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(476, 365);
            this.tlpMain.TabIndex = 0;
            // 
            // gbStartSplits
            // 
            this.gbStartSplits.AutoSize = true;
            this.gbStartSplits.Controls.Add(this.tlpStartSplits);
            this.gbStartSplits.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbStartSplits.Location = new System.Drawing.Point(3, 3);
            this.gbStartSplits.Name = "gbStartSplits";
            this.gbStartSplits.Size = new System.Drawing.Size(470, 42);
            this.gbStartSplits.TabIndex = 5;
            this.gbStartSplits.TabStop = false;
            this.gbStartSplits.Text = "Start Auto-splits";
            // 
            // tlpStartSplits
            // 
            this.tlpStartSplits.AutoSize = true;
            this.tlpStartSplits.BackColor = System.Drawing.Color.Transparent;
            this.tlpStartSplits.ColumnCount = 1;
            this.tlpStartSplits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStartSplits.Controls.Add(this.chkAutoStart, 0, 0);
            this.tlpStartSplits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartSplits.Location = new System.Drawing.Point(3, 16);
            this.tlpStartSplits.Name = "tlpStartSplits";
            this.tlpStartSplits.RowCount = 2;
            this.tlpStartSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStartSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStartSplits.Size = new System.Drawing.Size(464, 23);
            this.tlpStartSplits.TabIndex = 4;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Checked = true;
            this.chkAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoStart.Location = new System.Drawing.Point(3, 3);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(87, 17);
            this.chkAutoStart.TabIndex = 4;
            this.chkAutoStart.Text = "Start / Reset";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // gbEndSplits
            // 
            this.gbEndSplits.AutoSize = true;
            this.gbEndSplits.Controls.Add(this.tlpEndSplits);
            this.gbEndSplits.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEndSplits.Location = new System.Drawing.Point(3, 51);
            this.gbEndSplits.Name = "gbEndSplits";
            this.gbEndSplits.Size = new System.Drawing.Size(470, 205);
            this.gbEndSplits.TabIndex = 7;
            this.gbEndSplits.TabStop = false;
            this.gbEndSplits.Text = "End Auto-splits";
            // 
            // tlpEndSplits
            // 
            this.tlpEndSplits.AutoSize = true;
            this.tlpEndSplits.BackColor = System.Drawing.Color.Transparent;
            this.tlpEndSplits.ColumnCount = 1;
            this.tlpEndSplits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEndSplits.Controls.Add(this.chkVault87, 0, 7);
            this.tlpEndSplits.Controls.Add(this.chkWalking, 0, 6);
            this.tlpEndSplits.Controls.Add(this.chkTargetPractice, 0, 4);
            this.tlpEndSplits.Controls.Add(this.chkMemorial, 0, 11);
            this.tlpEndSplits.Controls.Add(this.chkWalking2, 0, 10);
            this.tlpEndSplits.Controls.Add(this.chkSPECIAL, 0, 0);
            this.tlpEndSplits.Controls.Add(this.chkEscape, 0, 5);
            this.tlpEndSplits.Controls.Add(this.chkFlashbang, 0, 7);
            this.tlpEndSplits.Controls.Add(this.chkEscape2, 0, 8);
            this.tlpEndSplits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEndSplits.Location = new System.Drawing.Point(3, 16);
            this.tlpEndSplits.Name = "tlpEndSplits";
            this.tlpEndSplits.RowCount = 11;
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEndSplits.Size = new System.Drawing.Size(464, 186);
            this.tlpEndSplits.TabIndex = 4;
            // 
            // gbDisplayAlternateTiming
            // 
            this.gbDisplayAlternateTiming.AutoSize = true;
            this.gbDisplayAlternateTiming.Controls.Add(this.tlpDisplayAlternateTiming);
            this.gbDisplayAlternateTiming.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDisplayAlternateTiming.Location = new System.Drawing.Point(3, 262);
            this.gbDisplayAlternateTiming.Name = "gbDisplayAlternateTiming";
            this.gbDisplayAlternateTiming.Size = new System.Drawing.Size(470, 42);
            this.gbDisplayAlternateTiming.TabIndex = 9;
            this.gbDisplayAlternateTiming.TabStop = false;
            this.gbDisplayAlternateTiming.Text = "Show Alternate Timing Method";
            // 
            // tlpDisplayAlternateTiming
            // 
            this.tlpDisplayAlternateTiming.AutoSize = true;
            this.tlpDisplayAlternateTiming.ColumnCount = 1;
            this.tlpDisplayAlternateTiming.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDisplayAlternateTiming.Controls.Add(this.chkDisplayWithoutLoads, 0, 0);
            this.tlpDisplayAlternateTiming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDisplayAlternateTiming.Location = new System.Drawing.Point(3, 16);
            this.tlpDisplayAlternateTiming.Name = "tlpDisplayAlternateTiming";
            this.tlpDisplayAlternateTiming.RowCount = 1;
            this.tlpDisplayAlternateTiming.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDisplayAlternateTiming.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpDisplayAlternateTiming.Size = new System.Drawing.Size(464, 23);
            this.tlpDisplayAlternateTiming.TabIndex = 0;
            // 
            // chkDisplayWithoutLoads
            // 
            this.chkDisplayWithoutLoads.AutoSize = true;
            this.chkDisplayWithoutLoads.Checked = true;
            this.chkDisplayWithoutLoads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayWithoutLoads.Location = new System.Drawing.Point(3, 3);
            this.chkDisplayWithoutLoads.Name = "chkDisplayWithoutLoads";
            this.chkDisplayWithoutLoads.Size = new System.Drawing.Size(59, 17);
            this.chkDisplayWithoutLoads.TabIndex = 0;
            this.chkDisplayWithoutLoads.Text = "Enable";
            this.chkDisplayWithoutLoads.UseVisualStyleBackColor = true;
            // 
            // chkMemorial
            // 
            this.chkMemorial.AutoSize = true;
            this.chkMemorial.Checked = true;
            this.chkMemorial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMemorial.Location = new System.Drawing.Point(3, 169);
            this.chkMemorial.Name = "chkMemorial";
            this.chkMemorial.Size = new System.Drawing.Size(68, 14);
            this.chkMemorial.TabIndex = 5;
            this.chkMemorial.Text = "Memorial";
            this.chkMemorial.UseVisualStyleBackColor = true;
            // 
            // chkTargetPractice
            // 
            this.chkTargetPractice.AutoSize = true;
            this.chkTargetPractice.Checked = true;
            this.chkTargetPractice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTargetPractice.Location = new System.Drawing.Point(3, 26);
            this.chkTargetPractice.Name = "chkTargetPractice";
            this.chkTargetPractice.Size = new System.Drawing.Size(99, 17);
            this.chkTargetPractice.TabIndex = 6;
            this.chkTargetPractice.Text = "Target Practice";
            this.chkTargetPractice.UseVisualStyleBackColor = true;
            // 
            // chkSPECIAL
            // 
            this.chkSPECIAL.AutoSize = true;
            this.chkSPECIAL.Checked = true;
            this.chkSPECIAL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSPECIAL.Location = new System.Drawing.Point(3, 3);
            this.chkSPECIAL.Name = "chkSPECIAL";
            this.chkSPECIAL.Size = new System.Drawing.Size(91, 17);
            this.chkSPECIAL.TabIndex = 7;
            this.chkSPECIAL.Text = "S.P.E.C.I.A.L.";
            this.chkSPECIAL.UseVisualStyleBackColor = true;
            // 
            // chkEscape
            // 
            this.chkEscape.AutoSize = true;
            this.chkEscape.Checked = true;
            this.chkEscape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEscape.Location = new System.Drawing.Point(3, 49);
            this.chkEscape.Name = "chkEscape";
            this.chkEscape.Size = new System.Drawing.Size(62, 14);
            this.chkEscape.TabIndex = 8;
            this.chkEscape.Text = "Escape";
            this.chkEscape.UseVisualStyleBackColor = true;
            // 
            // chkWalking
            // 
            this.chkWalking.AutoSize = true;
            this.chkWalking.Checked = true;
            this.chkWalking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWalking.Location = new System.Drawing.Point(3, 69);
            this.chkWalking.Name = "chkWalking";
            this.chkWalking.Size = new System.Drawing.Size(65, 14);
            this.chkWalking.TabIndex = 9;
            this.chkWalking.Text = "Walking";
            this.chkWalking.UseVisualStyleBackColor = true;
            // 
            // chkVault87
            // 
            this.chkVault87.AutoSize = true;
            this.chkVault87.Checked = true;
            this.chkVault87.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVault87.Location = new System.Drawing.Point(3, 89);
            this.chkVault87.Name = "chkVault87";
            this.chkVault87.Size = new System.Drawing.Size(65, 14);
            this.chkVault87.TabIndex = 10;
            this.chkVault87.Text = "Vault 87";
            this.chkVault87.UseVisualStyleBackColor = true;
            // 
            // chkFlashbang
            // 
            this.chkFlashbang.AutoSize = true;
            this.chkFlashbang.Checked = true;
            this.chkFlashbang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlashbang.Location = new System.Drawing.Point(3, 109);
            this.chkFlashbang.Name = "chkFlashbang";
            this.chkFlashbang.Size = new System.Drawing.Size(75, 14);
            this.chkFlashbang.TabIndex = 11;
            this.chkFlashbang.Text = "Flashbang";
            this.chkFlashbang.UseVisualStyleBackColor = true;
            // 
            // chkEscape2
            // 
            this.chkEscape2.AutoSize = true;
            this.chkEscape2.Checked = true;
            this.chkEscape2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEscape2.Location = new System.Drawing.Point(3, 129);
            this.chkEscape2.Name = "chkEscape2";
            this.chkEscape2.Size = new System.Drawing.Size(68, 14);
            this.chkEscape2.TabIndex = 12;
            this.chkEscape2.Text = "Escape2";
            this.chkEscape2.UseVisualStyleBackColor = true;
            // 
            // chkWalking2
            // 
            this.chkWalking2.AutoSize = true;
            this.chkWalking2.Checked = true;
            this.chkWalking2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWalking2.Location = new System.Drawing.Point(3, 149);
            this.chkWalking2.Name = "chkWalking2";
            this.chkWalking2.Size = new System.Drawing.Size(74, 14);
            this.chkWalking2.TabIndex = 13;
            this.chkWalking2.Text = "Walking 2";
            this.chkWalking2.UseVisualStyleBackColor = true;
            // 
            // Fallout3Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "Fallout3Settings";
            this.Size = new System.Drawing.Size(476, 443);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.gbStartSplits.ResumeLayout(false);
            this.gbStartSplits.PerformLayout();
            this.tlpStartSplits.ResumeLayout(false);
            this.tlpStartSplits.PerformLayout();
            this.gbEndSplits.ResumeLayout(false);
            this.gbEndSplits.PerformLayout();
            this.tlpEndSplits.ResumeLayout(false);
            this.tlpEndSplits.PerformLayout();
            this.gbDisplayAlternateTiming.ResumeLayout(false);
            this.gbDisplayAlternateTiming.PerformLayout();
            this.tlpDisplayAlternateTiming.ResumeLayout(false);
            this.tlpDisplayAlternateTiming.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbStartSplits;
        private System.Windows.Forms.GroupBox gbEndSplits;
        private System.Windows.Forms.TableLayoutPanel tlpEndSplits;
        private System.Windows.Forms.TableLayoutPanel tlpStartSplits;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkDisplayWithoutLoads;
        private System.Windows.Forms.GroupBox gbDisplayAlternateTiming;
        private System.Windows.Forms.TableLayoutPanel tlpDisplayAlternateTiming;
        private System.Windows.Forms.CheckBox chkMemorial;
        private System.Windows.Forms.CheckBox chkWalking2;
        private System.Windows.Forms.CheckBox chkEscape2;
        private System.Windows.Forms.CheckBox chkFlashbang;
        private System.Windows.Forms.CheckBox chkVault87;
        private System.Windows.Forms.CheckBox chkWalking;
        private System.Windows.Forms.CheckBox chkEscape;
        private System.Windows.Forms.CheckBox chkSPECIAL;
        private System.Windows.Forms.CheckBox chkTargetPractice;
    }
}
