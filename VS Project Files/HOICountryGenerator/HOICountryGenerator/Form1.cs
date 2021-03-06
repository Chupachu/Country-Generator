﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Drawing.Imaging;
using KUtility;

//using DevIL;
namespace HOICountryGenerator
{
    public partial class Form1 : Form
    {
        public string countryName;
        public string countryTag;
        public string countryAdjective;
        public string countryCapital;
        public string rulingParty;
        public List<string> ideologies = new List<string>();
        public List<string> idePop = new List<string>();
        public List<string> ideologyNames = new List<string>();
        public string flagDir;
        public string ideologyDir;
        public string colorR;
        public string colorG;
        public string colorB;
        public bool versionNag = true;

        public string historyFileDir;

        public Form1()
        {
            InitializeComponent();
        }
        
        public void SplitIdeStrings(bool resetVals)
        {
            
            int tpop = 0;
            if (ideologyDir == ""|ideologyDir == null)
                return;
            StreamReader sr = new StreamReader(ideologyDir, true);
            string ideTxt = sr.ReadToEnd();
            ideologyNames.Clear();
            ideologies.Clear();
            string[] lines = ideTxt.Replace('\r', '\n').Split('\n');
            if (resetVals)
                idePop.Clear();
            List<string> _lines = new List<string>();
            foreach (string line in lines)
            {
                if (line != string.Empty &&line!="\n")
                    _lines.Add(line);//.Replace("\n", string.Empty));
            }
            lines = _lines.ToArray();
            int miniIdeCount = 0;
            foreach (string line in lines)
            {
                if (line.Split('|').Length == 2)
                {
                    ideologies.Add(line.Split('|')[0]);
                    if(line!=lines.Last())
                        ideologyNames.Add(line.Split('|')[1]);
                    else
                        ideologyNames.Add(line.Split('|')[1]);
                    if (resetVals)
                    {
                        int amtPerIde = (100 / (lines.Length));
                        tpop += amtPerIde;
                        idePop.Add("" + amtPerIde);
                    }
                    miniIdeCount += 1;
                }
            }

            if(miniIdeCount==0)
            {
                MessageBox.Show("ERROR: Ideology file submitted contains no ideologies.  Verify you selected the right file and that it separates ideology from localization with a | symbol.","Invalid Ideology File");
                OFD_Ideologies.FileName = "";
                TB_Ideologies.Text = "";
                return;
            }
            if(resetVals)
                LBL_Tpop.Text = "Total popularity: " + tpop;
            List<string> _idenames = new List<string>();
            foreach (string name in ideologyNames)
            {

                string tempname;
                tempname = name.Replace("[NAME]", countryName);
                tempname = tempname.Replace("[ADJ]", countryAdjective);
                //tempname.Replace("\n", "");
                _idenames.Add(tempname);
            }
            ideologyNames = _idenames;
            CB_Rulingparty.Items.Clear();
            foreach (string ide in ideologies) {
                CB_Rulingparty.Items.Add(ide);
            }
            CB_Rulingparty.SelectedIndex = 0;
            rulingParty = ideologies[CB_Rulingparty.SelectedIndex];
        }
        public void IdeNames()
        {

        }
        void CheckToUnlockIde()
        {
            //if (TB_Tag.Text != null & TB_Tag.Text != "" & TB_Name.Text != null & TB_Name.Text != "" & TB_Adj.Text != null & TB_Adj.Text != "")
            //    BTN_ideologies.Enabled = true;
            //else
            //    BTN_ideologies.Enabled = false;
        }
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            //File.Create("out.yml");

            //LOCALIZATION SECTION
            string _dest = "";
            if (TB_Modfolder.Text != "")
                _dest = TB_Modfolder.Text;
            string lines;
            lines = File.ReadAllText(OFD_Loc.FileName);
            
            int ind = 0;
            foreach(string ideology in ideologies)
            {
                lines += " "+countryTag;
                lines += "_" + ideology + ":0 ";
                lines += '\u0022';
                //if (ind != ideologies.Count - 1)
                    //lines += ideologyNames[ind].Remove(ideologyNames[ind].Length - 1, 1);
                //else
                    lines += ideologyNames[ind];
                lines += '\u0022';
                lines += "\n";

                lines += " " + countryTag;
                lines += "_" + ideology + "_DEF:0 ";
                lines += '\u0022';
                lines += ideologyNames[ind];
                lines += '\u0022';
                lines += "\n";
                lines += " " + countryTag;
                lines += "_" + ideology + "_ADJ:0 ";
                lines += '\u0022';
                lines += countryAdjective;
                lines += '\u0022';
                lines += "\n";

                //lines += '\n';
                //FLAG SECTION
                string _dir;
                if (checkBox1.Checked) {
                    _dir = OFD_Flag.FileName.Replace(OFD_Flag.SafeFileName, "");
                    string[] flagname = OFD_Flag.SafeFileName.Split('.');
                    if (File.Exists(_dir + countryTag + "_" + ideology + "." + flagname[1]))
                        File.Delete(_dir + countryTag + "_" + ideology + "." + flagname[1]);
                    File.Copy(OFD_Flag.FileName, _dir + countryTag + "_" + ideology + "." + flagname[1]);
                }
                ind += 1;
            }
            string dest="";
            if (TB_Modfolder.Text != "")
                dest = TB_Modfolder.Text;

            //StreamWriter objWriter = new StreamWriter(OFD_Loc.FileName);
            Stream s = File.Open(""+OFD_Loc.FileName,FileMode.Open);
            //add bom
            //s.WriteByte(32);
            using (var sw = new StreamWriter(s, new UTF8Encoding(true)))
            {
                sw.WriteLine(lines);
            }
            //s.Close();
            //objWriter.Write(lines);
            //objWriter.Close();
            //File.WriteAllText(OFD_Loc.FileName, lines);
            //File.WriteAllLines("out.yml",lines);
            //HISTORY SECTION
            string dir;
            dir = FBD_History.SelectedPath;
            //File.Copy("GENERICHISTORY.txt", dir + countryTag + " - " + countryName+".txt");
            string txt = File.ReadAllText(historyFileDir);
            txt = txt.Replace("[NAME]", countryName);
            //MessageBox.Show(txt);
            txt = txt.Replace("[TAG]", countryTag);
            //MessageBox.Show(txt);
            txt = txt.Replace("[CAPNUM]", countryCapital);
            //MessageBox.Show(txt);
            txt = txt.Replace("[TAG]", countryTag);
            //MessageBox.Show(txt);
            txt = txt.Replace("[RULINGPARTY]", rulingParty);
            //MessageBox.Show(txt);
            string parties = "";
            int count = 0;
            foreach (string party in ideologies)
            {
                parties += "        "+party + " = " + idePop[count] + "\r\n";
                    count += 1;
            }
            txt = txt.Replace("[PARTIES]", parties);
            if (File.Exists(dir + "/" + countryTag + " - " + countryName + ".txt"))
                File.Delete(dir + "/" + countryTag + " - " + countryName + ".txt");
            s = File.Create(dir + "/" + countryTag + " - " + countryName + ".txt");
            using (var sw = new StreamWriter(s, new UTF8Encoding(true)))
            {
                sw.WriteLine(txt);
            }

            //File.WriteAllText(dir + "/" + countryTag + " - " + countryName + ".txt", txt);
            //objWriter = new StreamWriter(dir + "/" + countryTag + " - " + countryName + ".txt");
            //foreach (string line in txt.Split('\n'))
            //    objWriter.WriteLine(line.Replace("\n",""));
            //objWriter.Close();

            //COUNTRYTAGS SECTION
            txt = File.ReadAllText(OFD_Countrytags.FileName);
            txt += "\n" + countryTag + " = \"countries/" + countryName + ".txt\"";
            //objWriter = new StreamWriter(OFD_Countrytags.FileName);
            //foreach (string line in txt.Split('\n'))
            //Somehow makes an extra line of code every time
            //    objWriter.WriteLine(line);
            //objWriter.Close();
            File.WriteAllText(OFD_Countrytags.FileName, txt);
            //COUNTRIES SECTION
            //objWriter = new StreamWriter(FBD_Countries.SelectedPath+"/"+countryName+".txt");
            txt = "graphical_culture = western_european_gfx\n";
            txt += "graphical_culture_2d = western_european_2d\n\n";
            txt += "color = { "+colorR+"  "+colorG+"  "+colorB+" }";
            File.WriteAllText(FBD_Countries.SelectedPath+"/"+countryName+".txt", txt);
            //foreach (string line in txt.Split('\n'))
            //    objWriter.WriteLine(line);

            //objWriter.Close();
            //COLORS SECTION
            txt = File.ReadAllText(OFD_Colors.FileName);
            txt += "\n"+countryTag+ " = {\ncolor = rgb { " + colorR+" "+colorG+" "+colorB+ " }\ncolor_ui = rgb { " + colorR + " " + colorG + " " + colorB + " }\n}";
            File.WriteAllText(OFD_Colors.FileName, txt);
            //objWriter = new StreamWriter(OFD_Colors.FileName);
            //foreach (string line in txt.Split('\n'))
            //    objWriter.WriteLine(line);

            //objWriter.Close();
            MessageBox.Show("Country: "+countryTag+" - "+countryName+" successfully created.","Success");
        }
            

        private void BTN_Ideologies_Click(object sender, EventArgs e)
        {
            //openFileDialog1.
            OFD_Ideologies.InitialDirectory = Application.StartupPath;
            OFD_Ideologies.ShowDialog();
        }



        private void OFD_Ideologies_FileOk(object sender, CancelEventArgs e)
        {
            BTN_ideologies.BackColor = Color.LimeGreen;
            TB_Ideologies.Text = OFD_Ideologies.FileName;
            ideologyDir = OFD_Ideologies.FileName;
            TB_Pop.Enabled = true;
            CB_Rulingparty.Enabled = true;
            TB_Locname.Enabled = true;
            BTN_Resetloc.Enabled = true;
            SplitIdeStrings(true);
        }

        private void BTN_Flag_Click(object sender, EventArgs e)
        {
            OFD_Flag.InitialDirectory = FBD_Modfolder.SelectedPath;
            OFD_Flag.ShowDialog();
            
        }

        private void OFD_Flag_FileOk(object sender, CancelEventArgs e)
        {
            BTN_Flag.BackColor = Color.LimeGreen;
            TB_Flag.Text = OFD_Flag.FileName;
            flagDir = OFD_Flag.FileName;
            
        }

        private void CB_Rulingparty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CB_Rulingparty.SelectedIndex!=-1) {
                BTN_Resetloc.Enabled = true;
                BTN_Rnd.Enabled = true;
                TB_Pop.Enabled = true;
                TB_Pop.Text = idePop[CB_Rulingparty.SelectedIndex];
                TB_Locname.Text = ideologyNames[CB_Rulingparty.SelectedIndex];
                rulingParty = ideologies[CB_Rulingparty.SelectedIndex];
            }
        }

        private void TB_Pop_TextChanged(object sender, EventArgs e)
        {
            idePop[CB_Rulingparty.SelectedIndex] = TB_Pop.Text;
            int v = 0;

            //SeriesCollection col;
            float[] pops = new float[ideologies.Count];
            chart1.Series.Clear();
            Series PieSeries1 = new Series("Pie1");
            PieSeries1.ChartType = SeriesChartType.Pie;
            //PieSeries1.Font = New Font("Times", 30);
            //PieSeries1.CustomProperties = "PieLabelStyle=Disabled";
            chart1.Series.Clear();
            float tpop =0;
            foreach (string pop in idePop)
            {
                float n;
                
                if(float.TryParse(pop, out n) & n!=0)
                {
                    Series item = new Series();
                    item.Name = ideologies[v];
                    pops[v]=n;
                    PieSeries1.Points.AddXY(ideologies[v], n);
                    tpop += n;
                }
                v += 1;
            }
            LBL_Tpop.Text = "Total popularity: " + tpop;
            
            //PieSeries1.Points.AddXY(ideologies, pops);
            //PieSeries1.Points.DataBindY(pops);
            chart1.Series.Insert(0, PieSeries1);
        }

        private void TB_Locname_TextChanged(object sender, EventArgs e)
        {
            ideologyNames[CB_Rulingparty.SelectedIndex] = TB_Locname.Text;
        }

        private void TB_Tag_TextChanged(object sender, EventArgs e)
        {
            CheckToUnlockIde();
            countryTag = TB_Tag.Text;
            if (OFD_Ideologies.CheckFileExists)
            {
                SplitIdeStrings(false);
            }
        }

        private void TB_Name_TextChanged(object sender, EventArgs e)
        {
            CheckToUnlockIde();
            countryName = TB_Name.Text;
            if (OFD_Ideologies.CheckFileExists)
            {
                SplitIdeStrings(false);
            }
        }

        private void TB_Adj_TextChanged(object sender, EventArgs e)
        {
            CheckToUnlockIde();
            countryAdjective = TB_Adj.Text;
            if (OFD_Ideologies.CheckFileExists)
            {
                SplitIdeStrings(false);
            }
        }

        private void BTN_Resetloc_Click(object sender, EventArgs e)
        {
            ideologies.Clear();
            SplitIdeStrings(true);
            TB_Locname.Text = ideologyNames[CB_Rulingparty.SelectedIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "/GENERICHISTORY.txt"))
            {
                TB_HistoryFile.Text = Application.StartupPath + "/GENERICHISTORY.txt";
                historyFileDir = Application.StartupPath + "/GENERICHISTORY.txt";
                BTN_HistoryFile.BackColor = Color.LimeGreen;
            }
                colorR = "150";
            colorG = "150";
            colorB = "150";
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) => {Changelog();timer.Dispose();},null, 500, System.Threading.Timeout.Infinite);
            
            if (NewerVersion())
            {
                BTN_Update.Enabled = true;
            }
            else
            {
                BTN_Update.Enabled = false;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void OFD_History_FileOk(object sender, CancelEventArgs e)
        {
            BTN_History.BackColor = Color.LimeGreen;
            TB_History.Text = FBD_History.SelectedPath;
        }

        private void BTN_History_Click(object sender, EventArgs e)
        {
            FBD_History.SelectedPath = FBD_Modfolder.SelectedPath;
            if (FBD_History.ShowDialog().ToString() != "Cancel")
            {
                TB_History.Text = FBD_History.SelectedPath;
                BTN_History.BackColor = Color.LimeGreen;
            }
            //else
                //TB_History.Text = "";
        }

        private void TB_Capital_TextChanged(object sender, EventArgs e)
        {
            countryCapital = TB_Capital.Text;
        }

        private void BTN_Countrytags_Click(object sender, EventArgs e)
        {
            OFD_Countrytags.InitialDirectory = FBD_Modfolder.SelectedPath;
            OFD_Countrytags.ShowDialog();
        }

        private void OFD_Countrytags_FileOk(object sender, CancelEventArgs e)
        {
            BTN_Countrytags.BackColor = Color.LimeGreen;
            TB_Countrytags.Text = OFD_Countrytags.FileName;
        }

        private void BTN_Countries_Click(object sender, EventArgs e)
        {
            FBD_Countries.SelectedPath = FBD_Modfolder.SelectedPath;
            if (FBD_Countries.ShowDialog().ToString() != "Cancel")
            {
                TB_Countries.Text = FBD_Countries.SelectedPath;
                BTN_Countries.BackColor = Color.LimeGreen;
            }
        }

        private void BTN_Colors_Click(object sender, EventArgs e)
        {
            OFD_Colors.InitialDirectory = FBD_Modfolder.SelectedPath;
            OFD_Colors.ShowDialog();
        }


        private void OFD_Colors_FileOk(object sender, CancelEventArgs e)
        {
            BTN_Colors.BackColor = Color.LimeGreen;
            TB_Colors.Text = OFD_Colors.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Flag.Enabled = checkBox1.Checked;
        }

        private void BTN_Pick_Click(object sender, EventArgs e)
        {
            Color col = new Color();
            col = Color.FromArgb(0, 0, 0, 0);
            CD_Picker.Color = col;
            if (CD_Picker.ShowDialog().ToString() != "Cancel")
            {
                colorR = "" + CD_Picker.Color.R;
                colorG = "" + CD_Picker.Color.G;
                colorB = "" + CD_Picker.Color.B;
                TB_R.Text = colorR;
                TB_G.Text = colorG;
                TB_B.Text = colorB;
            }
            
        }

        private void TB_R_TextChanged(object sender, EventArgs e)
        {
            colorR = TB_R.Text;
        }

        private void TB_G_TextChanged(object sender, EventArgs e)
        {
            colorG = TB_G.Text;
        }

        private void TB_B_TextChanged(object sender, EventArgs e)
        {
            colorB = TB_B.Text;
        }

        private void FBD_History_HelpRequest(object sender, EventArgs e)
        {
            TB_History.Text = FBD_History.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help("Ideology File Help", "This file loads the ideologies for the country and generates preset localized names based off it.  This file can be easily modified and is usually found in the same folder as the application.  You can make your own variant for your ideologies and specify it here.");
        }
        void Help(string title, string text)
        {
            MessageBox.Show(text, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help("Flag File Help", "This field will take a flag that you want to copy, copy it in the same location as your target flag, and immedately name it like so: TAG_ideology for each ideology specified.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help("History Folder Help", "When a history file is generated for your nation from GENERICHISTORY.txt (or your own custom history file), the file will be sent to this destination.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help("Country Tags Help", "A new country tag line will be inserted into this file.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help("Countries Folder Help", "A new country file will be created in this destination. (This is not a history or tag file, it simply allows the game to recognize this nation exists.)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help("Colors File Help","A new country color scope will be inserted into this file to set the nation's color.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Help("Mod Folder Help", "Speficying this isn't important, but it makes searching for files much quicker.");
        }
        void DDSToPNG(string path)
        {
            //byte[] bytes = File.ReadAllBytes(path);
            //PB_Logo.Image = DevIL.DevIL.LoadBitmap(path);
            //MessageBox.Show(bytes.ToString());
            
        }
        private void BTN_Modfolder_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(FBD_Modfolder.SelectedPath);
            //FBD_Modfolder.SelectedPath = "C:/Users/" + Environment.UserName + "/Documents/Paradox Interactive/Hearts of Iron IV/mod";
            //MessageBox.Show(FBD_Modfolder.SelectedPath);
            if (FBD_Modfolder.ShowDialog().ToString() == "OK")
            {

                string modloc = FBD_Modfolder.SelectedPath;
                TB_Modfolder.Text = FBD_Modfolder.SelectedPath.ToString();
                string picloc = modloc + "/gfx/interface/logo_game.dds";
                if (File.Exists(picloc))
                {

                }
                if (Directory.Exists(modloc + "/history/countries")) {
                    MessageBox.Show("history/countries detected", "File autodetect");
                    FBD_History.SelectedPath = modloc + "/history/countries";
                    TB_History.Text = FBD_History.SelectedPath;
                    BTN_History.BackColor = Color.LimeGreen;
                }
                if (File.Exists(modloc + "/common/country_tags/00_countries.txt"))
                {
                    MessageBox.Show("country_tags/00_countries.txt detected", "File autodetect");
                    OFD_Countrytags.FileName = modloc + "/common/country_tags/00_countries.txt";
                    TB_Countrytags.Text = OFD_Countrytags.FileName;
                    BTN_Countrytags.BackColor = Color.LimeGreen;
                }
                if (Directory.Exists(modloc + "/common/countries"))
                {
                    MessageBox.Show("common/countries detected", "File autodetect");
                    FBD_Countries.SelectedPath = modloc + "/common/countries";
                    TB_Countries.Text = FBD_Countries.SelectedPath;
                    BTN_Countries.BackColor = Color.LimeGreen;
                }
                if (File.Exists(modloc + "/common/countries/colors.txt"))
                {
                    MessageBox.Show("colors.txt detected", "File autodetect");
                    OFD_Colors.FileName = modloc + "/common/countries/colors.txt";
                    TB_Colors.Text = OFD_Colors.FileName;
                    BTN_Colors.BackColor = Color.LimeGreen;
                }
                if (File.Exists(modloc + "/localisation/countries_l_english.yml"))
                {
                    MessageBox.Show("country localisation detected", "File autodetect");
                    OFD_Loc.FileName = modloc + "/localisation/countries_l_english.yml";
                    TB_Loc.Text = OFD_Loc.FileName;
                    BTN_Loc.BackColor = Color.LimeGreen;
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Help("Localization Help", "Localization, or if you're one of those 'Europe' people, localisation, is what  separates code_names_with_underscores from normal text.  In this case, it's your country name based on which ideologies you imported.  These are automatically generated when you import the ideology file I wrote, but you can change them by typing in the Localization field.  When you hit submit, they will be exported to MOD (if one is specified)/localisation/out.yml.  Feel free to move them into your country's localization file afterwards, or leave them there if you're lazy, as the files in there shouldn't get overwritten.");
        }

        private void FBD_Modfolder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void BTN_Rnd_Click(object sender, EventArgs e)
        {
            float total = 0;
            List<float> nums = new List<float>();
            foreach (string ide in idePop )
            {
                bool isNum = true;
                float res;
                float.TryParse(ide, out res);
                if (res == 0f)
                    isNum = false;
                    if (isNum)
                {
                    total += float.Parse(ide);
                    nums.Add(float.Parse(ide));
                }

            }
            //MessageBox.Show(""+total);
            
            List<float> _nums = new List<float>();
            
            foreach (float num in nums)
            {
                _nums.Add((num / total) * 100f);
                
            }
            total = 0;
            int count=0;
            foreach (float num in _nums)
            {
                total += num;
                idePop[count] = ""+ num;
                count+= 1;
            }
            //MessageBox.Show("" + total);
            TB_Pop.Text = ""+_nums[CB_Rulingparty.SelectedIndex];
        }

        private void BTN_Loc_Click(object sender, EventArgs e)
        {
            OFD_Loc.InitialDirectory = FBD_Modfolder.SelectedPath;
            OFD_Loc.ShowDialog();
        }

        private void OFD_Loc_FileOk(object sender, CancelEventArgs e)
        {
            BTN_Loc.BackColor = Color.LimeGreen;
            TB_Loc.Text = OFD_Loc.FileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Help("Localization Help", "This field is the location where country names can be found.  For example, in countries_l_english.yml, you would find GER_fascism:0 \"German Reich\".");
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            
            UpdateScript();
        }
        public bool NewerVersion()
        {
            bool newer = false;
            string version1 = File.ReadAllText("version.txt");
            //MessageBox.Show(version1);
            string[] ver1Split = version1.Split('.');
            string version2 = new StreamReader(new WebClient().OpenRead("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/version.txt")).ReadToEnd();
            //MessageBox.Show(version2);
            string[] ver2Split = version2.Split('.');
            for (int v = ver1Split.Length-1; v > 0; v--)
            {
                int num1;
                int num2;
                int.TryParse(ver1Split[v], out num1);
                int.TryParse(ver2Split[v], out num2);
                if (num1 < num2)
                {
                    newer = true;
                }
                if (num1 > num2)
                {
                    newer = false;
                }
            }
            if(!newer)
                LBL_Version.Text = "Version: " + version1 + " (latest)";
            else
                LBL_Version.Text = "Version: " + version1 + " (outdated)";
            if (newer&&versionNag==true)
            {
                versionNag = false;
                System.Threading.Timer timer = null;
                timer = new System.Threading.Timer((obj) => { MessageBox.Show("(Version: "+version1+") There's a new version available: " + version2,"Update Available"); timer.Dispose(); }, null, 500, System.Threading.Timeout.Infinite);
            }
            
            //Console.Write();
            return newer;
        }
        public void UpdateScript()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        | SecurityProtocolType.Tls11
        | SecurityProtocolType.Tls12
        | SecurityProtocolType.Ssl3;
            //MessageBox.Show(Application.ProductVersion);
            Download("https://github.com/Chupachu/Country-Generator/blob/master/CountryGenerator/HOICountryGenerator.exe?raw=true", "HOICountryGenerator_Backup.exe");
            Download("https://github.com/Chupachu/Country-Generator/blob/master/CountryGenerator/HCG_Updater.exe?raw=true", "HCG_Updater.exe");
            //Download("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/version.txt", "version.txt");
            //Download("https://raw.githubusercontent.com/Chupachu/Country-Generator/master/CountryGenerator/changelog.txt", "changelog.txt");
            System.Diagnostics.Process.Start("HCG_Updater.exe");
            Application.Exit();
        }
        public void Download(string path, string name)
        {
            new WebClient().DownloadFile(path, name);
        }
        public void Changelog()
        {
            if (File.Exists("changelog.txt"))
            {
                string changelogtext = File.ReadAllText("changelog.txt");
                string title = File.ReadAllText("changelog.txt").Split('\n')[0];
                changelogtext=changelogtext.Replace(title + '\n', "");
                MessageBox.Show(changelogtext, title);
                File.Delete("changelog.txt");
            }
        }

        private void CB_ForceUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ForceUpdate.Checked)
            {
                BTN_Update.Enabled = true;
            }
            else
            {
                if (!NewerVersion())
                {
                    BTN_Update.Enabled = false;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Help("HistoryFile Help", "This option is by default set to DEFAULTHISTORY.txt, and can be used to set custom modded history files for use in overhaul mods.");
        }

        private void BTN_HistoryFile_Click(object sender, EventArgs e)
        {
            OFD_HistoryFile.InitialDirectory = Application.StartupPath; ;
            OFD_HistoryFile.ShowDialog();
        }

        private void OFD_HistoryFile_FileOk(object sender, CancelEventArgs e)
        {
            BTN_HistoryFile.BackColor = Color.LimeGreen;
            TB_HistoryFile.Text = OFD_HistoryFile.FileName;
            historyFileDir = OFD_HistoryFile.FileName;
        }

        private void PB_Logo_Click(object sender, EventArgs e)
        {

        }


        //public string ParseChangelogText(string text)
        //{
        //    text = text.Replace("\\\\", "\n");
        //    return text;
        //}
    }
}
