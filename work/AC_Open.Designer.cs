namespace ACTest1.work
{
    partial class AC_Open
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupRunDelayTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStopRun = new System.Windows.Forms.Button();
            this.txbFlow = new System.Windows.Forms.TextBox();
            this.btnStepRun = new System.Windows.Forms.Button();
            this.lbRepeatTimes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nupRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEnterPosY = new System.Windows.Forms.Label();
            this.lbEnterPosX = new System.Windows.Forms.Label();
            this.lbAddPosY = new System.Windows.Forms.Label();
            this.lbAddPosX = new System.Windows.Forms.Label();
            this.lbUsePosY = new System.Windows.Forms.Label();
            this.lbUsePosX = new System.Windows.Forms.Label();
            this.lbOpenPosY = new System.Windows.Forms.Label();
            this.lbEnterPos = new System.Windows.Forms.Label();
            this.lbAddPos = new System.Windows.Forms.Label();
            this.lbUsePos = new System.Windows.Forms.Label();
            this.lbOpenPosX = new System.Windows.Forms.Label();
            this.lbOpenPos = new System.Windows.Forms.Label();
            this.ScanTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRunDelayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRepeatTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.nupRunDelayTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnStopRun);
            this.panel1.Controls.Add(this.txbFlow);
            this.panel1.Controls.Add(this.btnStepRun);
            this.panel1.Controls.Add(this.lbRepeatTimes);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nupRepeatTimes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbEnterPosY);
            this.panel1.Controls.Add(this.lbEnterPosX);
            this.panel1.Controls.Add(this.lbAddPosY);
            this.panel1.Controls.Add(this.lbAddPosX);
            this.panel1.Controls.Add(this.lbUsePosY);
            this.panel1.Controls.Add(this.lbUsePosX);
            this.panel1.Controls.Add(this.lbOpenPosY);
            this.panel1.Controls.Add(this.lbEnterPos);
            this.panel1.Controls.Add(this.lbAddPos);
            this.panel1.Controls.Add(this.lbUsePos);
            this.panel1.Controls.Add(this.lbOpenPosX);
            this.panel1.Controls.Add(this.lbOpenPos);
            this.panel1.Location = new System.Drawing.Point(45, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 468);
            this.panel1.TabIndex = 1;
            // 
            // nupRunDelayTime
            // 
            this.nupRunDelayTime.Location = new System.Drawing.Point(132, 310);
            this.nupRunDelayTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupRunDelayTime.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupRunDelayTime.Name = "nupRunDelayTime";
            this.nupRunDelayTime.Size = new System.Drawing.Size(76, 25);
            this.nupRunDelayTime.TabIndex = 31;
            this.nupRunDelayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupRunDelayTime.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "等待時間";
            // 
            // btnStopRun
            // 
            this.btnStopRun.BackColor = System.Drawing.Color.Red;
            this.btnStopRun.Location = new System.Drawing.Point(199, 373);
            this.btnStopRun.Margin = new System.Windows.Forms.Padding(5);
            this.btnStopRun.Name = "btnStopRun";
            this.btnStopRun.Size = new System.Drawing.Size(89, 59);
            this.btnStopRun.TabIndex = 30;
            this.btnStopRun.Text = "EMS";
            this.btnStopRun.UseVisualStyleBackColor = false;
            this.btnStopRun.Click += new System.EventHandler(this.btnStopRun_Click);
            // 
            // txbFlow
            // 
            this.txbFlow.Location = new System.Drawing.Point(12, 440);
            this.txbFlow.Name = "txbFlow";
            this.txbFlow.ReadOnly = true;
            this.txbFlow.Size = new System.Drawing.Size(296, 25);
            this.txbFlow.TabIndex = 28;
            // 
            // btnStepRun
            // 
            this.btnStepRun.Location = new System.Drawing.Point(42, 373);
            this.btnStepRun.Margin = new System.Windows.Forms.Padding(5);
            this.btnStepRun.Name = "btnStepRun";
            this.btnStepRun.Size = new System.Drawing.Size(107, 59);
            this.btnStepRun.TabIndex = 25;
            this.btnStepRun.Text = "StepRun";
            this.btnStepRun.UseVisualStyleBackColor = true;
            this.btnStepRun.Click += new System.EventHandler(this.btnStepRun_Click);
            // 
            // lbRepeatTimes
            // 
            this.lbRepeatTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRepeatTimes.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbRepeatTimes.Location = new System.Drawing.Point(214, 283);
            this.lbRepeatTimes.Name = "lbRepeatTimes";
            this.lbRepeatTimes.Size = new System.Drawing.Size(74, 19);
            this.lbRepeatTimes.TabIndex = 27;
            this.lbRepeatTimes.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "#循環次數";
            // 
            // nupRepeatTimes
            // 
            this.nupRepeatTimes.Location = new System.Drawing.Point(134, 277);
            this.nupRepeatTimes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupRepeatTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRepeatTimes.Name = "nupRepeatTimes";
            this.nupRepeatTimes.Size = new System.Drawing.Size(74, 25);
            this.nupRepeatTimes.TabIndex = 29;
            this.nupRepeatTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupRepeatTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 90);
            this.label1.TabIndex = 14;
            this.label1.Text = "1.點擊標籤兩下，反紅\r\n2.按Ctrl+F1紀錄滑鼠位置\r\n\r\n";
            // 
            // lbEnterPosY
            // 
            this.lbEnterPosY.BackColor = System.Drawing.SystemColors.Control;
            this.lbEnterPosY.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnterPosY.Location = new System.Drawing.Point(214, 244);
            this.lbEnterPosY.Name = "lbEnterPosY";
            this.lbEnterPosY.Size = new System.Drawing.Size(74, 19);
            this.lbEnterPosY.TabIndex = 13;
            // 
            // lbEnterPosX
            // 
            this.lbEnterPosX.BackColor = System.Drawing.SystemColors.Control;
            this.lbEnterPosX.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnterPosX.Location = new System.Drawing.Point(134, 244);
            this.lbEnterPosX.Name = "lbEnterPosX";
            this.lbEnterPosX.Size = new System.Drawing.Size(74, 19);
            this.lbEnterPosX.TabIndex = 12;
            // 
            // lbAddPosY
            // 
            this.lbAddPosY.BackColor = System.Drawing.SystemColors.Control;
            this.lbAddPosY.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAddPosY.Location = new System.Drawing.Point(214, 206);
            this.lbAddPosY.Name = "lbAddPosY";
            this.lbAddPosY.Size = new System.Drawing.Size(74, 19);
            this.lbAddPosY.TabIndex = 11;
            // 
            // lbAddPosX
            // 
            this.lbAddPosX.BackColor = System.Drawing.SystemColors.Control;
            this.lbAddPosX.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAddPosX.Location = new System.Drawing.Point(134, 206);
            this.lbAddPosX.Name = "lbAddPosX";
            this.lbAddPosX.Size = new System.Drawing.Size(74, 19);
            this.lbAddPosX.TabIndex = 10;
            // 
            // lbUsePosY
            // 
            this.lbUsePosY.BackColor = System.Drawing.SystemColors.Control;
            this.lbUsePosY.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUsePosY.Location = new System.Drawing.Point(214, 169);
            this.lbUsePosY.Name = "lbUsePosY";
            this.lbUsePosY.Size = new System.Drawing.Size(74, 19);
            this.lbUsePosY.TabIndex = 9;
            // 
            // lbUsePosX
            // 
            this.lbUsePosX.BackColor = System.Drawing.SystemColors.Control;
            this.lbUsePosX.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUsePosX.Location = new System.Drawing.Point(134, 169);
            this.lbUsePosX.Name = "lbUsePosX";
            this.lbUsePosX.Size = new System.Drawing.Size(74, 19);
            this.lbUsePosX.TabIndex = 8;
            // 
            // lbOpenPosY
            // 
            this.lbOpenPosY.BackColor = System.Drawing.SystemColors.Control;
            this.lbOpenPosY.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOpenPosY.Location = new System.Drawing.Point(214, 129);
            this.lbOpenPosY.Name = "lbOpenPosY";
            this.lbOpenPosY.Size = new System.Drawing.Size(74, 19);
            this.lbOpenPosY.TabIndex = 5;
            // 
            // lbEnterPos
            // 
            this.lbEnterPos.AutoSize = true;
            this.lbEnterPos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbEnterPos.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEnterPos.Location = new System.Drawing.Point(38, 244);
            this.lbEnterPos.Name = "lbEnterPos";
            this.lbEnterPos.Size = new System.Drawing.Size(90, 19);
            this.lbEnterPos.TabIndex = 4;
            this.lbEnterPos.Text = "確定位置:";
            this.lbEnterPos.Click += new System.EventHandler(this.lbSetPos_Click);
            // 
            // lbAddPos
            // 
            this.lbAddPos.AutoSize = true;
            this.lbAddPos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbAddPos.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbAddPos.Location = new System.Drawing.Point(38, 206);
            this.lbAddPos.Name = "lbAddPos";
            this.lbAddPos.Size = new System.Drawing.Size(90, 19);
            this.lbAddPos.TabIndex = 3;
            this.lbAddPos.Text = "加號位置:";
            this.lbAddPos.Click += new System.EventHandler(this.lbSetPos_Click);
            // 
            // lbUsePos
            // 
            this.lbUsePos.AutoSize = true;
            this.lbUsePos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbUsePos.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUsePos.Location = new System.Drawing.Point(38, 169);
            this.lbUsePos.Name = "lbUsePos";
            this.lbUsePos.Size = new System.Drawing.Size(90, 19);
            this.lbUsePos.TabIndex = 2;
            this.lbUsePos.Text = "使用位置:";
            this.lbUsePos.Click += new System.EventHandler(this.lbSetPos_Click);
            // 
            // lbOpenPosX
            // 
            this.lbOpenPosX.BackColor = System.Drawing.SystemColors.Control;
            this.lbOpenPosX.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOpenPosX.Location = new System.Drawing.Point(134, 129);
            this.lbOpenPosX.Name = "lbOpenPosX";
            this.lbOpenPosX.Size = new System.Drawing.Size(74, 19);
            this.lbOpenPosX.TabIndex = 1;
            // 
            // lbOpenPos
            // 
            this.lbOpenPos.AutoSize = true;
            this.lbOpenPos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbOpenPos.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOpenPos.Location = new System.Drawing.Point(38, 129);
            this.lbOpenPos.Name = "lbOpenPos";
            this.lbOpenPos.Size = new System.Drawing.Size(90, 19);
            this.lbOpenPos.TabIndex = 0;
            this.lbOpenPos.Text = "開啟位置:";
            this.lbOpenPos.Click += new System.EventHandler(this.lbSetPos_Click);
            // 
            // ScanTimer
            // 
            this.ScanTimer.Tick += new System.EventHandler(this.ScanTimer_Tick);
            // 
            // AC_Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AC_Open";
            this.Size = new System.Drawing.Size(430, 557);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRunDelayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRepeatTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStopRun;
        private System.Windows.Forms.TextBox txbFlow;
        private System.Windows.Forms.Button btnStepRun;
        private System.Windows.Forms.Label lbRepeatTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupRepeatTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEnterPosY;
        private System.Windows.Forms.Label lbEnterPosX;
        private System.Windows.Forms.Label lbAddPosY;
        private System.Windows.Forms.Label lbAddPosX;
        private System.Windows.Forms.Label lbUsePosY;
        private System.Windows.Forms.Label lbUsePosX;
        private System.Windows.Forms.Label lbOpenPosY;
        private System.Windows.Forms.Label lbEnterPos;
        private System.Windows.Forms.Label lbAddPos;
        private System.Windows.Forms.Label lbUsePos;
        private System.Windows.Forms.Label lbOpenPosX;
        private System.Windows.Forms.Label lbOpenPos;
        private System.Windows.Forms.Timer ScanTimer;
        private System.Windows.Forms.NumericUpDown nupRunDelayTime;
        private System.Windows.Forms.Label label4;
    }
}
