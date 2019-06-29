using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace HCG_Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Download();
        }


        void Download()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        | SecurityProtocolType.Tls11
        | SecurityProtocolType.Tls12
        | SecurityProtocolType.Ssl3;
            WebClient main = new WebClient();
            main.DownloadFile("https://github.com/Chupachu/Country-Generator/blob/master/CountryGenerator/HOICountryGenerator.exe?raw=true", "HOICountryGenerator.exe");
            new WebClient().DownloadFile("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/version.txt", "version.txt");
            new WebClient().DownloadFile("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/GENERICHISTORY.txt", "GENERICHISTORY.txt");
            new WebClient().DownloadFile("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/ideologies.txt", "ideologies.txt");
            new WebClient().DownloadFile("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/changelog.txt", "changelog.txt");
            System.Threading.Timer timer = null;
            //timer = new System.Threading.Timer((obj) => { MessageBox.Show("(Version: ) There's a new version available:", "Update Available"); timer.Dispose(); }, null, 500, System.Threading.Timeout.Infinite);
            System.Diagnostics.Process.Start("HOICountryGenerator.exe");
            while (main.IsBusy)
            {
                //MessageBox.Show("I'M BUSY");
                int count = 0;
            }
            //Application.Exit();
            timer = new System.Threading.Timer((obj) => { OneSecond(); timer.Dispose(); }, null, 1500, System.Threading.Timeout.Infinite);

        }
        void OneSecond()
        {
            Application.Exit();
        }
    }
}
