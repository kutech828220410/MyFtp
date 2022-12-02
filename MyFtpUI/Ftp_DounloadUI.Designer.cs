namespace MyFtpUI
{
    partial class Ftp_DounloadUI
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
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbProgress = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.panel_FTP = new System.Windows.Forms.Panel();
            this.groupBox_FTP = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_FTP_Server = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFTP_Serverd = new System.Windows.Forms.TextBox();
            this.panel_Username = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Password = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_FTP.SuspendLayout();
            this.groupBox_FTP.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_FTP_Server.SuspendLayout();
            this.panel_Username.SuspendLayout();
            this.panel_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.panel2);
            this.groupBox_Main.Controls.Add(this.panel_FTP);
            this.groupBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Main.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Size = new System.Drawing.Size(431, 235);
            this.groupBox_Main.TabIndex = 0;
            this.groupBox_Main.TabStop = false;
            this.groupBox_Main.Text = "Download Data through FTP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.lbProgress);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtFileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 89);
            this.panel2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 21);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(332, 8);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(84, 21);
            this.btnDownload.TabIndex = 28;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "Progress:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(75, 58);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 21);
            this.progressBar1.TabIndex = 25;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(332, 63);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(20, 12);
            this.lbProgress.TabIndex = 26;
            this.lbProgress.Text = "0/0";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(75, 33);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(245, 22);
            this.txtData.TabIndex = 24;
            this.txtData.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Data in\r\nMemory:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(75, 9);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(245, 22);
            this.txtFileName.TabIndex = 22;
            this.txtFileName.Text = "Setup.msi";
            // 
            // panel_FTP
            // 
            this.panel_FTP.Controls.Add(this.groupBox_FTP);
            this.panel_FTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FTP.Location = new System.Drawing.Point(3, 18);
            this.panel_FTP.Name = "panel_FTP";
            this.panel_FTP.Size = new System.Drawing.Size(425, 125);
            this.panel_FTP.TabIndex = 2;
            // 
            // groupBox_FTP
            // 
            this.groupBox_FTP.Controls.Add(this.flowLayoutPanel1);
            this.groupBox_FTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FTP.Location = new System.Drawing.Point(0, 0);
            this.groupBox_FTP.Name = "groupBox_FTP";
            this.groupBox_FTP.Size = new System.Drawing.Size(425, 125);
            this.groupBox_FTP.TabIndex = 12;
            this.groupBox_FTP.TabStop = false;
            this.groupBox_FTP.Text = "FTP";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel_FTP_Server);
            this.flowLayoutPanel1.Controls.Add(this.panel_Username);
            this.flowLayoutPanel1.Controls.Add(this.panel_Password);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 104);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_FTP_Server
            // 
            this.panel_FTP_Server.Controls.Add(this.label1);
            this.panel_FTP_Server.Controls.Add(this.txtFTP_Serverd);
            this.panel_FTP_Server.Location = new System.Drawing.Point(1, 1);
            this.panel_FTP_Server.Margin = new System.Windows.Forms.Padding(1);
            this.panel_FTP_Server.Name = "panel_FTP_Server";
            this.panel_FTP_Server.Size = new System.Drawing.Size(338, 32);
            this.panel_FTP_Server.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "FTP Server:";
            // 
            // txtFTP_Serverd
            // 
            this.txtFTP_Serverd.Location = new System.Drawing.Point(73, 5);
            this.txtFTP_Serverd.Name = "txtFTP_Serverd";
            this.txtFTP_Serverd.Size = new System.Drawing.Size(244, 22);
            this.txtFTP_Serverd.TabIndex = 8;
            this.txtFTP_Serverd.Text = "ftp://kutech.myds.me/FTP";
            // 
            // panel_Username
            // 
            this.panel_Username.Controls.Add(this.txtUsername);
            this.panel_Username.Controls.Add(this.label2);
            this.panel_Username.Location = new System.Drawing.Point(1, 35);
            this.panel_Username.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Username.Name = "panel_Username";
            this.panel_Username.Size = new System.Drawing.Size(338, 32);
            this.panel_Username.TabIndex = 27;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(73, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(244, 22);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // panel_Password
            // 
            this.panel_Password.Controls.Add(this.txtPassword);
            this.panel_Password.Controls.Add(this.label3);
            this.panel_Password.Location = new System.Drawing.Point(1, 69);
            this.panel_Password.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Password.Name = "panel_Password";
            this.panel_Password.Size = new System.Drawing.Size(338, 32);
            this.panel_Password.TabIndex = 29;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(73, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(244, 22);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // Ftp_DounloadUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox_Main);
            this.Name = "Ftp_DounloadUI";
            this.Size = new System.Drawing.Size(431, 235);
            this.groupBox_Main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_FTP.ResumeLayout(false);
            this.groupBox_FTP.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_FTP_Server.ResumeLayout(false);
            this.panel_FTP_Server.PerformLayout();
            this.panel_Username.ResumeLayout(false);
            this.panel_Username.PerformLayout();
            this.panel_Password.ResumeLayout(false);
            this.panel_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.GroupBox groupBox_Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Panel panel_FTP;
        private System.Windows.Forms.GroupBox groupBox_FTP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_FTP_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFTP_Serverd;
        private System.Windows.Forms.Panel panel_Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Password;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
    }
}
