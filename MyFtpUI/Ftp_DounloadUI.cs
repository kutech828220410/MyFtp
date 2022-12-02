//Downloaded from
//Visual C# Kicks - http://vcskicks.com/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Needed
using System.IO;
using System.Net;
using System.Diagnostics;
namespace MyFtpUI
{
    public partial class Ftp_DounloadUI : UserControl
    {
        private byte[] downloadedData;

        [ReadOnly(false), Browsable(true), Category("一般參數"), Description(""), DefaultValue("")]
        public bool Username_要顯示
        {
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.panel_Username.Visible = value; }));
                }
                else this.panel_Username.Visible = value; 
            }
            get
            {
                return this.panel_Username.Visible;
            }
        }
        [ReadOnly(false), Browsable(true), Category("一般參數"), Description(""), DefaultValue("")]
        public bool Password_要顯示
        {
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.panel_Password.Visible = value; }));
                }
                else this.panel_Password.Visible = value;
            }
            get
            {
                return this.panel_Password.Visible;
            }
        }
        [ReadOnly(false), Browsable(true), Category("一般參數"), Description(""), DefaultValue("")] 
        public bool FTP_Server_要顯示
        {
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.panel_FTP_Server.Visible = value; }));
                }
                else this.panel_FTP_Server.Visible = value;
            }
            get
            {
                return this.panel_FTP_Server.Visible;
            }
        }
        [ReadOnly(false), Browsable(true), Category("一般參數"), Description(""), DefaultValue("")]
        public bool FTP_Groupbox_要顯示
        {
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.panel_FTP.Visible = value; }));
                }
                else this.panel_FTP.Visible = value;
            }
            get
            {
                return this.panel_FTP.Visible;
            }
        }

        [ReadOnly(false), Browsable(true), Category("FTP"), Description(""), DefaultValue("")]
        public string Username
        {
            get { return this.@txtUsername.Text; }
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.txtUsername.Text = @value; }));
                }
                else this.txtUsername.Text = value;
            }
        }
        [ReadOnly(false), Browsable(true), Category("FTP"), Description(""), DefaultValue("")]
        public string Password
        {
            get { return this.txtPassword.Text; }
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.txtPassword.Text = @value; }));
                }
                else this.txtPassword.Text = value;
            }
        }
        [ReadOnly(false), Browsable(true), Category("FTP"), Description(""), DefaultValue("")]
        public string FTP_Server
        {
            get { return this.txtFTP_Serverd.Text; }
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.txtFTP_Serverd.Text = @value; }));
                }
                else this.txtFTP_Serverd.Text = value;
            }
        }
        [ReadOnly(false), Browsable(true), Category("FTP"), Description(""), DefaultValue("")]
        public string FileName
        {
            get { return this.txtFileName.Text; }
            set
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke(new Action(delegate { this.txtFileName.Text = @value; }));
                }
                else this.txtFileName.Text = value;
            }
        }

        [ReadOnly(false), Browsable(false), Category(""), Description(""), DefaultValue("")]
        //private string DesktopPath = Application.LocalUserAppDataPath;
        private string DesktopPath  = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public Ftp_DounloadUI()
        {
            InitializeComponent();
        }

        public void RunFile(Form form)
        {
            this.RunFile(@DesktopPath + "/" + this.FileName, form);
        }
        public void RunFile(string filename, Form form)
        {
            //關閉程式

            Process P_new = new Process();
            //設定一秒延遲,讓程式順利關閉才能刪除 
            P_new.StartInfo = new ProcessStartInfo("cmd.exe", "/C choice /C Y /N /D Y /T 1 & " + "\"" + filename + "\"");
            P_new.StartInfo.CreateNoWindow = true;
            P_new.StartInfo.UseShellExecute = false;
            P_new.Start();

            form.Close();
            Process.GetCurrentProcess().Close();
            Process.GetCurrentProcess().CloseMainWindow();

     
           // this.Install(@filename);
        }

        private void Install(string filename)
        {
            string strInput = @filename;
            Process p_package = new Process();
            p_package.StartInfo.FileName = "cmd.exe";
            p_package.StartInfo.UseShellExecute = false;
            p_package.StartInfo.RedirectStandardInput = true;
            p_package.StartInfo.RedirectStandardOutput = true;
            p_package.StartInfo.RedirectStandardError = true;
            p_package.StartInfo.CreateNoWindow = false;
            p_package.Start();
            p_package.StandardInput.WriteLine(@strInput + "&exit");
            p_package.StandardInput.AutoFlush = true;
            string strOuput = p_package.StandardOutput.ReadToEnd();

            p_package.WaitForInputIdle();
            p_package.Close();
        }
        private void UnInstall(string filename)
        {
            string strInput = @"msiexec /uninstall " + @filename + " ";
            Process p_package = new Process();
            p_package.StartInfo.FileName = "cmd.exe";
            p_package.StartInfo.UseShellExecute = false;
            p_package.StartInfo.RedirectStandardInput = true;
            p_package.StartInfo.RedirectStandardOutput = true;
            p_package.StartInfo.RedirectStandardError = true;
            p_package.StartInfo.CreateNoWindow = false;
            p_package.Start();
            p_package.StandardInput.WriteLine(strInput + "&exit");
            p_package.StandardInput.AutoFlush = true;
            string strOuput = p_package.StandardOutput.ReadToEnd();

            p_package.WaitForExit();
            p_package.Close();
        }

        public string GetFileVersion()
        {
            string fileName = Path.GetFileNameWithoutExtension(this.FileName) + ".ini";
            this.DownloadFile(this.FTP_Server, fileName, this.Username, this.Password, false);
            this.SaveFile(@DesktopPath + "/" + fileName);
            try
            {
                using (StreamReader oStreamReader = new StreamReader(Path.Combine(Application.StartupPath, @DesktopPath + "/" + fileName), Encoding.Default))
                {
                    string text = oStreamReader.ReadLine();
                    Console.WriteLine($"Online Version : {text}");
                    return text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }
        public bool CheckUpdate(string currentVersion, string updateVersion)
        {
            currentVersion = currentVersion.Replace(".", "");
            updateVersion = updateVersion.Replace(".", "");

            int _currentVersion = 0;
            int _updateVersion = 0;

            if (!int.TryParse(currentVersion, out _currentVersion)) return false;
            if (!int.TryParse(updateVersion, out _updateVersion)) return false;

            if (_updateVersion > _currentVersion) return true;
            else return false;
        }

       
        public bool DownloadFile()
        {
            return this.DownloadFile(false);
        }
        public bool DownloadFile(bool ShowMessage)
        {
            return this.DownloadFile(this.FTP_Server, this.FileName, this.Username, this.Password, ShowMessage);
        }
        public bool DownloadFile(string FTPAddress, string filename, string username, string password , bool ShowMessage)
        {
            bool flag_OK = true;
            downloadedData = new byte[0];

            try
            {
                //Optional
                if (ShowMessage) this.groupBox_Main.Text = "Connecting...";
                Application.DoEvents();

                //Create FTP request
                //Note: format is ftp://server.com/file.ext
                FtpWebRequest request = FtpWebRequest.Create(FTPAddress + "/" + filename) as FtpWebRequest;

                //Optional
                if (ShowMessage) this.groupBox_Main.Text = "Retrieving Information...";
                Application.DoEvents();

                //Get the file size first (for progress bar)
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true; //don't close the connection

                int dataLength = (int)request.GetResponse().ContentLength;

                //Optional
                if (ShowMessage) this.groupBox_Main.Text = "Downloading File...";
                Application.DoEvents();

                //Now get the actual data
                request = FtpWebRequest.Create(FTPAddress + "/" + filename) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false; //close the connection when done

                //Set up progress bar
                this.BeginInvoke(new Action(delegate
                {
                    progressBar1.Value = 0;
                    progressBar1.Maximum = dataLength;
                    lbProgress.Text = "0/" + dataLength.ToString();

                }));


                //Streams
                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream reader = response.GetResponseStream();

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                byte[] buffer = new byte[1024]; //downloads in chuncks

                while (true)
                {
                    Application.DoEvents(); //prevent application from crashing

                    //Try to read the data
                    int bytesRead = reader.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        //Nothing was read, finished downloading
                        this.BeginInvoke(new Action(delegate
                        {
                            progressBar1.Value = progressBar1.Maximum;
                            lbProgress.Text = dataLength.ToString() + "/" + dataLength.ToString();
                            Console.WriteLine($"{lbProgress.Text }");
                        }));
                      

                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        memStream.Write(buffer, 0, bytesRead);
                        this.BeginInvoke(new Action(delegate
                        {
                            if (progressBar1.Value + bytesRead <= progressBar1.Maximum)
                            {
                                progressBar1.Value += bytesRead;
                                lbProgress.Text = progressBar1.Value.ToString() + "/" + dataLength.ToString();
                                Console.WriteLine($"{lbProgress.Text }");
                                progressBar1.Refresh();
                                Application.DoEvents();
                            }

                        }));
                        //Update the progress bar
                   
                    }
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                reader.Close();
                memStream.Close();
                response.Close();
                if (ShowMessage)
                {
                    MessageBox.Show("Downloaded Successfully");
                    Console.WriteLine($"Downloaded Successfully!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error connecting to the FTP Server.");
                flag_OK = false;
            }
            this.BeginInvoke(new Action(delegate
            {
                txtData.Text = downloadedData.Length.ToString();
            }));
            if (ShowMessage) this.groupBox_Main.Text = "Download Data through FTP";

            username = string.Empty;
            password = string.Empty;
            return flag_OK;
        }

        public bool SaveFile()
        {
            return this.SaveFile(@DesktopPath + "/" + this.FileName);
        }
        public bool SaveFile(string filename)
        {
            if (downloadedData != null && downloadedData.Length != 0)
            {
                FileStream newFile = new FileStream(filename, FileMode.Create);
                newFile.Write(downloadedData, 0, downloadedData.Length);
                newFile.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Connects to the FTP server and request the list of available files
        public void GetFileList(string FTPAddress, string username, string password)
        {
            List<string> files = new List<string>();

            try
            {
                //Optional
                this.groupBox_Main.Text = "Connecting...";
                Application.DoEvents();

                //Create FTP request
                FtpWebRequest request = FtpWebRequest.Create(FTPAddress) as FtpWebRequest;

                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                //Read the server's response
                this.groupBox_Main.Text = "Retrieving List...";
                Application.DoEvents();

                FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    Application.DoEvents();
                    files.Add(reader.ReadLine());
                }

                //Clean-up
                reader.Close();
                responseStream.Close(); //redundant
                response.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error connecting to the FTP Server");
            }

            username = string.Empty;
            password = string.Empty;

            this.groupBox_Main.Text = "Download Data through FTP"; //Back to normal title

  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (downloadedData != null && downloadedData.Length != 0)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    this.groupBox_Main.Text = "Saving Data...";
                    Application.DoEvents();

                    //Write the bytes to a file
                    this.SaveFile(this.saveFile.FileName);

                    this.groupBox_Main.Text = "Download Data";
                    MessageBox.Show("Saved Successfully");
                }
            }
            else
                MessageBox.Show("No File was Downloaded Yet!");
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
     

            if (txtFTP_Serverd.Text != "ftp://" && txtFTP_Serverd.Text != string.Empty)
                if (txtFileName.Text != string.Empty)
                {
                    DownloadFile(txtFTP_Serverd.Text, txtFileName.Text, txtUsername.Text, txtPassword.Text ,true);

                    saveFile.FileName = txtFileName.Text;
                }
                else
                    MessageBox.Show("Please enter a file name or click the Get File List button");
            else
                MessageBox.Show("Please enter a FTP address");
        }

    }
}
