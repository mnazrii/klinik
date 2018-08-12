
using AppLimit.CloudComputing.SharpBox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace Klinik3
{
    public partial class UpdateForm : Form
    {


        public static List<string> info = new List<string>();

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\nLatest version:" + downloaddata[0]);
            dropBoxStorage.DownloadFile("/" + downloaddata[1], Directory.GetCurrentDirectory() + "/download/", UploadDownloadProgress);
            
            dropBoxStorage.Close();
            
            var processname = Process.GetCurrentProcess().ProcessName;
            var archive = "download\\" + downloaddata[1];

            callupdater(processname, archive);
           
        }

        private void callupdater(string processname, string archive)
        {
            var extraupdate = "extraupdate.bat";
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "install.bat";
            p.Arguments = processname + " " + archive+" "+ extraupdate;

            p.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(p);

        }

        public static void UploadDownloadProgress(Object sender, FileDataTransferEventArgs e)
        {
            // print a dot
            Console.Write(".");
            // it's ok to go forward
            e.Cancel = false;
        }
        CloudStorage dropBoxStorage;
        private void UpdateMe_Load(object sender, EventArgs e)
        {
            label2.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            updateResult.Visible = false;
            Update_bttn.Visible = false;

            dropBoxStorage = new CloudStorage();
            // get the configuration for dropbox
            var dropBoxConfig =
            CloudStorage.GetCloudConfigurationEasy(nSupportedCloudConfigurations.DropBox);

            // declare an access token
            ICloudStorageAccessToken accessToken = null;
            // load a valid security token from file
            using (FileStream fs = File.Open("SharpDropBox.Token",
            FileMode.Open, FileAccess.Read,
            FileShare.None))
            {
                accessToken = dropBoxStorage.DeserializeSecurityToken(fs);
            }

            // open the connection
            var storageToken = dropBoxStorage.Open(dropBoxConfig, accessToken);
            //
            // do what ever you want to
            //
        }

        string[] downloaddata;
        private void checkForUpdate_bttn_Click(object sender, EventArgs e)
        {
            dropBoxStorage.DownloadFile("/klinik.version.txt", Directory.GetCurrentDirectory() + "/download", UploadDownloadProgress);
            var lines = new List<string>(File.ReadLines("download/klinik.version.txt"));


            var latest = string.IsNullOrEmpty(lines[lines.Count - 1]) ?
                                lines[lines.Count - 2] : lines[lines.Count - 1];

            //version;filename
            downloaddata = latest.Split(';');
            //download filename

            labellatestversion.Text = downloaddata[0];
            Console.WriteLine("\nLatest version:" + downloaddata[0]);

            // close the connection
            //dropBoxStorage.Close();
            Update_bttn.Visible = true;
        }





    }
}