namespace MyFtp
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
            this.ftp_DounloadUI1 = new MyFtpUI.Ftp_DounloadUI();
            this.SuspendLayout();
            // 
            // ftp_DounloadUI1
            // 
            this.ftp_DounloadUI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ftp_DounloadUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftp_DounloadUI1.DownloadType = MyFtpUI.Ftp_DounloadUI.E_DownloadType.URL;
            this.ftp_DounloadUI1.FileName = "Setup.msi";
            this.ftp_DounloadUI1.FTP_Groupbox_要顯示 = true;
            this.ftp_DounloadUI1.FTP_Server = "https://github.com/kutech828220410/Pharmacy/raw/master/Advance%20Install";
            this.ftp_DounloadUI1.FTP_Server_要顯示 = true;
            this.ftp_DounloadUI1.Location = new System.Drawing.Point(0, 0);
            this.ftp_DounloadUI1.Name = "ftp_DounloadUI1";
            this.ftp_DounloadUI1.Password = "test";
            this.ftp_DounloadUI1.Password_要顯示 = true;
            this.ftp_DounloadUI1.Size = new System.Drawing.Size(438, 425);
            this.ftp_DounloadUI1.TabIndex = 0;
            this.ftp_DounloadUI1.Username = "test";
            this.ftp_DounloadUI1.Username_要顯示 = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 425);
            this.Controls.Add(this.ftp_DounloadUI1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyFtpUI.Ftp_DounloadUI ftp_DounloadUI1;
    }
}

