namespace Kipitter
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkSetting = new System.Windows.Forms.LinkLabel();
            this.linkKnights = new System.Windows.Forms.LinkLabel();
            this.linkAlarm = new System.Windows.Forms.LinkLabel();
            this.linkBattleTimer = new System.Windows.Forms.LinkLabel();
            this.linkTradeBoard = new System.Windows.Forms.LinkLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listConsole = new System.Windows.Forms.ListBox();
            this.erinnTimer = new System.Windows.Forms.Timer(this.components);
            this.realTimer = new System.Windows.Forms.Timer(this.components);
            this.toolWeekEffect = new System.Windows.Forms.ToolTip(this.components);
            this.labelRealTime = new System.Windows.Forms.Label();
            this.labelErinnTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelErinnTime);
            this.splitContainer1.Panel1.Controls.Add(this.labelRealTime);
            this.splitContainer1.Panel1.Controls.Add(this.linkSetting);
            this.splitContainer1.Panel1.Controls.Add(this.linkKnights);
            this.splitContainer1.Panel1.Controls.Add(this.linkAlarm);
            this.splitContainer1.Panel1.Controls.Add(this.linkBattleTimer);
            this.splitContainer1.Panel1.Controls.Add(this.linkTradeBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(448, 331);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // linkSetting
            // 
            this.linkSetting.ActiveLinkColor = System.Drawing.Color.White;
            this.linkSetting.AutoSize = true;
            this.linkSetting.DisabledLinkColor = System.Drawing.Color.White;
            this.linkSetting.LinkColor = System.Drawing.Color.White;
            this.linkSetting.Location = new System.Drawing.Point(412, 3);
            this.linkSetting.Name = "linkSetting";
            this.linkSetting.Size = new System.Drawing.Size(33, 11);
            this.linkSetting.TabIndex = 4;
            this.linkSetting.TabStop = true;
            this.linkSetting.Text = "設定";
            this.linkSetting.VisitedLinkColor = System.Drawing.Color.White;
            this.linkSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSetting_LinkClicked);
            // 
            // linkKnights
            // 
            this.linkKnights.ActiveLinkColor = System.Drawing.Color.White;
            this.linkKnights.AutoSize = true;
            this.linkKnights.DisabledLinkColor = System.Drawing.Color.White;
            this.linkKnights.LinkColor = System.Drawing.Color.White;
            this.linkKnights.Location = new System.Drawing.Point(218, 3);
            this.linkKnights.Name = "linkKnights";
            this.linkKnights.Size = new System.Drawing.Size(47, 11);
            this.linkKnights.TabIndex = 3;
            this.linkKnights.TabStop = true;
            this.linkKnights.Text = "騎士団";
            this.linkKnights.VisitedLinkColor = System.Drawing.Color.White;
            this.linkKnights.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKnights_LinkClicked);
            // 
            // linkAlarm
            // 
            this.linkAlarm.ActiveLinkColor = System.Drawing.Color.White;
            this.linkAlarm.AutoSize = true;
            this.linkAlarm.DisabledLinkColor = System.Drawing.Color.White;
            this.linkAlarm.LinkColor = System.Drawing.Color.White;
            this.linkAlarm.Location = new System.Drawing.Point(151, 3);
            this.linkAlarm.Name = "linkAlarm";
            this.linkAlarm.Size = new System.Drawing.Size(61, 11);
            this.linkAlarm.TabIndex = 2;
            this.linkAlarm.TabStop = true;
            this.linkAlarm.Text = "アラーム";
            this.linkAlarm.VisitedLinkColor = System.Drawing.Color.White;
            this.linkAlarm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlarm_LinkClicked);
            // 
            // linkBattleTimer
            // 
            this.linkBattleTimer.ActiveLinkColor = System.Drawing.Color.White;
            this.linkBattleTimer.AutoSize = true;
            this.linkBattleTimer.DisabledLinkColor = System.Drawing.Color.White;
            this.linkBattleTimer.LinkColor = System.Drawing.Color.White;
            this.linkBattleTimer.Location = new System.Drawing.Point(56, 3);
            this.linkBattleTimer.Name = "linkBattleTimer";
            this.linkBattleTimer.Size = new System.Drawing.Size(89, 11);
            this.linkBattleTimer.TabIndex = 1;
            this.linkBattleTimer.TabStop = true;
            this.linkBattleTimer.Text = "戦闘タイマー";
            this.linkBattleTimer.VisitedLinkColor = System.Drawing.Color.White;
            this.linkBattleTimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBattleTimer_LinkClicked);
            // 
            // linkTradeBoard
            // 
            this.linkTradeBoard.ActiveLinkColor = System.Drawing.Color.White;
            this.linkTradeBoard.AutoSize = true;
            this.linkTradeBoard.DisabledLinkColor = System.Drawing.Color.White;
            this.linkTradeBoard.LinkColor = System.Drawing.Color.White;
            this.linkTradeBoard.Location = new System.Drawing.Point(3, 3);
            this.linkTradeBoard.Name = "linkTradeBoard";
            this.linkTradeBoard.Size = new System.Drawing.Size(47, 11);
            this.linkTradeBoard.TabIndex = 0;
            this.linkTradeBoard.TabStop = true;
            this.linkTradeBoard.Text = "取引板";
            this.linkTradeBoard.VisitedLinkColor = System.Drawing.Color.White;
            this.linkTradeBoard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTradeBoard_LinkClicked);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listConsole);
            this.splitContainer2.Size = new System.Drawing.Size(448, 274);
            this.splitContainer2.SplitterDistance = 191;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // listConsole
            // 
            this.listConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConsole.ForeColor = System.Drawing.Color.White;
            this.listConsole.FormattingEnabled = true;
            this.listConsole.ItemHeight = 11;
            this.listConsole.Location = new System.Drawing.Point(0, 0);
            this.listConsole.Name = "listConsole";
            this.listConsole.Size = new System.Drawing.Size(448, 82);
            this.listConsole.TabIndex = 0;
            // 
            // erinnTimer
            // 
            this.erinnTimer.Enabled = true;
            this.erinnTimer.Interval = 500;
            this.erinnTimer.Tick += new System.EventHandler(this.erinnTimer_Tick);
            // 
            // realTimer
            // 
            this.realTimer.Enabled = true;
            this.realTimer.Interval = 500;
            this.realTimer.Tick += new System.EventHandler(this.realTimer_Tick);
            // 
            // toolWeekEffect
            // 
            this.toolWeekEffect.AutoPopDelay = 20000;
            this.toolWeekEffect.InitialDelay = 500;
            this.toolWeekEffect.ReshowDelay = 100;
            this.toolWeekEffect.ShowAlways = true;
            // 
            // labelRealTime
            // 
            this.labelRealTime.AutoSize = true;
            this.labelRealTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRealTime.ForeColor = System.Drawing.Color.White;
            this.labelRealTime.Location = new System.Drawing.Point(3, 21);
            this.labelRealTime.Name = "labelRealTime";
            this.labelRealTime.Size = new System.Drawing.Size(0, 11);
            this.labelRealTime.TabIndex = 8;
            // 
            // labelErinnTime
            // 
            this.labelErinnTime.AutoSize = true;
            this.labelErinnTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelErinnTime.ForeColor = System.Drawing.Color.White;
            this.labelErinnTime.Location = new System.Drawing.Point(3, 34);
            this.labelErinnTime.Name = "labelErinnTime";
            this.labelErinnTime.Size = new System.Drawing.Size(0, 11);
            this.labelErinnTime.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(448, 331);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Ricty", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(464, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(464, 370);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kipitter";
            this.Load += new System.EventHandler(this.main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.LinkLabel linkTradeBoard;
        private System.Windows.Forms.LinkLabel linkBattleTimer;
        private System.Windows.Forms.LinkLabel linkAlarm;
        private System.Windows.Forms.LinkLabel linkKnights;
        private System.Windows.Forms.LinkLabel linkSetting;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listConsole;
        private System.Windows.Forms.Timer erinnTimer;
        private System.Windows.Forms.Timer realTimer;
        private System.Windows.Forms.ToolTip toolWeekEffect;
        private System.Windows.Forms.Label labelErinnTime;
        private System.Windows.Forms.Label labelRealTime;
    }
}

