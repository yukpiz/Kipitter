namespace Kipitter
{
    partial class PaneAlarm
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.radioErinnTime = new System.Windows.Forms.RadioButton();
            this.radioRealTime = new System.Windows.Forms.RadioButton();
            this.dgAlarms = new System.Windows.Forms.DataGridView();
            this.textMemo = new System.Windows.Forms.TextBox();
            this.timemode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarms)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textMemo);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numMinutes);
            this.splitContainer1.Panel1.Controls.Add(this.numHours);
            this.splitContainer1.Panel1.Controls.Add(this.radioErinnTime);
            this.splitContainer1.Panel1.Controls.Add(this.radioRealTime);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgAlarms);
            this.splitContainer1.Size = new System.Drawing.Size(335, 221);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(282, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "追加";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 11);
            this.label2.TabIndex = 5;
            this.label2.Text = "分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 11);
            this.label1.TabIndex = 4;
            this.label1.Text = "時";
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(146, 6);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(37, 19);
            this.numMinutes.TabIndex = 3;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(89, 6);
            this.numHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(37, 19);
            this.numHours.TabIndex = 2;
            // 
            // radioErinnTime
            // 
            this.radioErinnTime.AutoSize = true;
            this.radioErinnTime.Location = new System.Drawing.Point(46, 8);
            this.radioErinnTime.Name = "radioErinnTime";
            this.radioErinnTime.Size = new System.Drawing.Size(37, 15);
            this.radioErinnTime.TabIndex = 1;
            this.radioErinnTime.Text = "ET";
            this.radioErinnTime.UseVisualStyleBackColor = true;
            // 
            // radioRealTime
            // 
            this.radioRealTime.AutoSize = true;
            this.radioRealTime.Checked = true;
            this.radioRealTime.Location = new System.Drawing.Point(7, 8);
            this.radioRealTime.Name = "radioRealTime";
            this.radioRealTime.Size = new System.Drawing.Size(37, 15);
            this.radioRealTime.TabIndex = 0;
            this.radioRealTime.TabStop = true;
            this.radioRealTime.Text = "RT";
            this.radioRealTime.UseVisualStyleBackColor = true;
            // 
            // dgAlarms
            // 
            this.dgAlarms.AllowUserToAddRows = false;
            this.dgAlarms.AllowUserToDeleteRows = false;
            this.dgAlarms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgAlarms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlarms.ColumnHeadersVisible = false;
            this.dgAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timemode,
            this.memo,
            this.hours,
            this.minutes,
            this.enabled});
            this.dgAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAlarms.Location = new System.Drawing.Point(0, 0);
            this.dgAlarms.Name = "dgAlarms";
            this.dgAlarms.RowHeadersVisible = false;
            this.dgAlarms.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgAlarms.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgAlarms.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgAlarms.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgAlarms.RowTemplate.Height = 21;
            this.dgAlarms.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAlarms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlarms.Size = new System.Drawing.Size(335, 189);
            this.dgAlarms.TabIndex = 0;
            // 
            // textMemo
            // 
            this.textMemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMemo.Location = new System.Drawing.Point(202, 5);
            this.textMemo.MaxLength = 7;
            this.textMemo.Name = "textMemo";
            this.textMemo.Size = new System.Drawing.Size(76, 19);
            this.textMemo.TabIndex = 7;
            // 
            // timemode
            // 
            this.timemode.DataPropertyName = "timemode";
            this.timemode.FillWeight = 17.63284F;
            this.timemode.HeaderText = "timemode";
            this.timemode.Name = "timemode";
            this.timemode.ReadOnly = true;
            this.timemode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.timemode.Width = 30;
            // 
            // memo
            // 
            this.memo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memo.DataPropertyName = "memo";
            this.memo.FillWeight = 253.8071F;
            this.memo.HeaderText = "memo";
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            this.memo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // hours
            // 
            this.hours.DataPropertyName = "hours";
            this.hours.FillWeight = 33.3358F;
            this.hours.HeaderText = "hours";
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            this.hours.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hours.Width = 30;
            // 
            // minutes
            // 
            this.minutes.DataPropertyName = "minutes";
            this.minutes.FillWeight = 65.22738F;
            this.minutes.HeaderText = "minutes";
            this.minutes.Name = "minutes";
            this.minutes.ReadOnly = true;
            this.minutes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.minutes.Width = 30;
            // 
            // enabled
            // 
            this.enabled.DataPropertyName = "enabled";
            this.enabled.FillWeight = 129.9969F;
            this.enabled.HeaderText = "enabled";
            this.enabled.Name = "enabled";
            this.enabled.ReadOnly = true;
            this.enabled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.enabled.Width = 50;
            // 
            // PaneAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Ricty", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PaneAlarm";
            this.Size = new System.Drawing.Size(335, 221);
            this.Load += new System.EventHandler(this.PaneAlarm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlarms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton radioRealTime;
        private System.Windows.Forms.RadioButton radioErinnTime;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dgAlarms;
        private System.Windows.Forms.TextBox textMemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn timemode;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabled;
    }
}
