namespace ACTest1
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ac1 = new ACTest1.work.AC_Open();
            this.SuspendLayout();
            // 
            // ac1
            // 
            this.ac1.Location = new System.Drawing.Point(0, 0);
            this.ac1.Name = "ac1";
            this.ac1.Size = new System.Drawing.Size(430, 557);
            this.ac1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 522);
            this.Controls.Add(this.ac1);
            this.Name = "Form1";
            this.Text = "自動使用道具";
            this.KeyPreview = true;
            this.ResumeLayout(false);

        }

        #endregion

        private work.AC_Open ac1;
    }
}

