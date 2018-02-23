namespace HOICountryGenerator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TB_Tag = new System.Windows.Forms.TextBox();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Adj = new System.Windows.Forms.TextBox();
            this.BTN_ideologies = new System.Windows.Forms.Button();
            this.TB_Ideologies = new System.Windows.Forms.TextBox();
            this.OFD_Ideologies = new System.Windows.Forms.OpenFileDialog();
            this.LBL_Ideologies = new System.Windows.Forms.Label();
            this.LBL_Flag = new System.Windows.Forms.Label();
            this.TB_Flag = new System.Windows.Forms.TextBox();
            this.BTN_Flag = new System.Windows.Forms.Button();
            this.OFD_Flag = new System.Windows.Forms.OpenFileDialog();
            this.CB_Rulingparty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Pop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Locname = new System.Windows.Forms.Label();
            this.TB_Locname = new System.Windows.Forms.TextBox();
            this.BTN_Resetloc = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LBL_Tpop = new System.Windows.Forms.Label();
            this.LBL_Capital = new System.Windows.Forms.Label();
            this.TB_Capital = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_History = new System.Windows.Forms.TextBox();
            this.BTN_History = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Countrytags = new System.Windows.Forms.TextBox();
            this.BTN_Countrytags = new System.Windows.Forms.Button();
            this.OFD_Countrytags = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Colors = new System.Windows.Forms.TextBox();
            this.BTN_Colors = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Countries = new System.Windows.Forms.TextBox();
            this.BTN_Countries = new System.Windows.Forms.Button();
            this.OFD_Colors = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CD_Picker = new System.Windows.Forms.ColorDialog();
            this.TB_R = new System.Windows.Forms.TextBox();
            this.TB_G = new System.Windows.Forms.TextBox();
            this.TB_B = new System.Windows.Forms.TextBox();
            this.BTN_Pick = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FBD_History = new System.Windows.Forms.FolderBrowserDialog();
            this.FBD_Countries = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_Modfolder = new System.Windows.Forms.TextBox();
            this.BTN_Modfolder = new System.Windows.Forms.Button();
            this.FBD_Modfolder = new System.Windows.Forms.FolderBrowserDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.BTN_Rnd = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.LBL_Loc = new System.Windows.Forms.Label();
            this.TB_Loc = new System.Windows.Forms.TextBox();
            this.BTN_Loc = new System.Windows.Forms.Button();
            this.OFD_Loc = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Tag
            // 
            this.TB_Tag.Location = new System.Drawing.Point(77, 6);
            this.TB_Tag.MaxLength = 5;
            this.TB_Tag.Name = "TB_Tag";
            this.TB_Tag.Size = new System.Drawing.Size(61, 20);
            this.TB_Tag.TabIndex = 0;
            this.TB_Tag.TextChanged += new System.EventHandler(this.TB_Tag_TextChanged);
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Location = new System.Drawing.Point(12, 9);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(29, 13);
            this.lbl_tag.TabIndex = 1;
            this.lbl_tag.Text = "TAG";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(77, 32);
            this.TB_Name.MaxLength = 100;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(147, 20);
            this.TB_Name.TabIndex = 1;
            this.TB_Name.TextChanged += new System.EventHandler(this.TB_Name_TextChanged);
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(12, 484);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Submit.TabIndex = 21;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Adjective";
            // 
            // TB_Adj
            // 
            this.TB_Adj.Location = new System.Drawing.Point(77, 58);
            this.TB_Adj.MaxLength = 100;
            this.TB_Adj.Name = "TB_Adj";
            this.TB_Adj.Size = new System.Drawing.Size(147, 20);
            this.TB_Adj.TabIndex = 2;
            this.TB_Adj.TextChanged += new System.EventHandler(this.TB_Adj_TextChanged);
            // 
            // BTN_ideologies
            // 
            this.BTN_ideologies.Location = new System.Drawing.Point(470, 55);
            this.BTN_ideologies.Name = "BTN_ideologies";
            this.BTN_ideologies.Size = new System.Drawing.Size(27, 23);
            this.BTN_ideologies.TabIndex = 13;
            this.BTN_ideologies.Text = "..";
            this.BTN_ideologies.UseVisualStyleBackColor = true;
            this.BTN_ideologies.Click += new System.EventHandler(this.BTN_Ideologies_Click);
            // 
            // TB_Ideologies
            // 
            this.TB_Ideologies.Location = new System.Drawing.Point(503, 58);
            this.TB_Ideologies.Name = "TB_Ideologies";
            this.TB_Ideologies.ReadOnly = true;
            this.TB_Ideologies.Size = new System.Drawing.Size(236, 20);
            this.TB_Ideologies.TabIndex = 7;
            this.TB_Ideologies.TabStop = false;
            this.TB_Ideologies.Text = "ideologies.txt";
            // 
            // OFD_Ideologies
            // 
            this.OFD_Ideologies.FileName = "openFileDialog1";
            this.OFD_Ideologies.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Ideologies_FileOk);
            // 
            // LBL_Ideologies
            // 
            this.LBL_Ideologies.AutoSize = true;
            this.LBL_Ideologies.Location = new System.Drawing.Point(578, 42);
            this.LBL_Ideologies.Name = "LBL_Ideologies";
            this.LBL_Ideologies.Size = new System.Drawing.Size(74, 13);
            this.LBL_Ideologies.TabIndex = 11;
            this.LBL_Ideologies.Text = "Ideologies File";
            this.LBL_Ideologies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Flag
            // 
            this.LBL_Flag.AutoSize = true;
            this.LBL_Flag.Location = new System.Drawing.Point(588, 81);
            this.LBL_Flag.Name = "LBL_Flag";
            this.LBL_Flag.Size = new System.Drawing.Size(54, 13);
            this.LBL_Flag.TabIndex = 14;
            this.LBL_Flag.Text = "Flag Base";
            this.LBL_Flag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Flag
            // 
            this.TB_Flag.Location = new System.Drawing.Point(503, 96);
            this.TB_Flag.Name = "TB_Flag";
            this.TB_Flag.ReadOnly = true;
            this.TB_Flag.Size = new System.Drawing.Size(236, 20);
            this.TB_Flag.TabIndex = 9;
            this.TB_Flag.TabStop = false;
            this.TB_Flag.Text = "EX: gfx\\flags\\flag_to_clone";
            // 
            // BTN_Flag
            // 
            this.BTN_Flag.Enabled = false;
            this.BTN_Flag.Location = new System.Drawing.Point(470, 93);
            this.BTN_Flag.Name = "BTN_Flag";
            this.BTN_Flag.Size = new System.Drawing.Size(27, 23);
            this.BTN_Flag.TabIndex = 15;
            this.BTN_Flag.Text = "..";
            this.BTN_Flag.UseVisualStyleBackColor = true;
            this.BTN_Flag.Click += new System.EventHandler(this.BTN_Flag_Click);
            // 
            // OFD_Flag
            // 
            this.OFD_Flag.FileName = "openFileDialog1";
            this.OFD_Flag.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Flag_FileOk);
            // 
            // CB_Rulingparty
            // 
            this.CB_Rulingparty.Enabled = false;
            this.CB_Rulingparty.FormattingEnabled = true;
            this.CB_Rulingparty.Location = new System.Drawing.Point(77, 84);
            this.CB_Rulingparty.Name = "CB_Rulingparty";
            this.CB_Rulingparty.Size = new System.Drawing.Size(147, 21);
            this.CB_Rulingparty.TabIndex = 3;
            this.CB_Rulingparty.SelectedIndexChanged += new System.EventHandler(this.CB_Rulingparty_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ruling Party";
            // 
            // TB_Pop
            // 
            this.TB_Pop.Enabled = false;
            this.TB_Pop.Location = new System.Drawing.Point(231, 87);
            this.TB_Pop.MaxLength = 3;
            this.TB_Pop.Name = "TB_Pop";
            this.TB_Pop.Size = new System.Drawing.Size(52, 20);
            this.TB_Pop.TabIndex = 4;
            this.TB_Pop.TextChanged += new System.EventHandler(this.TB_Pop_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Popularity";
            // 
            // LBL_Locname
            // 
            this.LBL_Locname.AutoSize = true;
            this.LBL_Locname.Location = new System.Drawing.Point(103, 108);
            this.LBL_Locname.Name = "LBL_Locname";
            this.LBL_Locname.Size = new System.Drawing.Size(83, 13);
            this.LBL_Locname.TabIndex = 19;
            this.LBL_Locname.Text = "Localized Name";
            // 
            // TB_Locname
            // 
            this.TB_Locname.Enabled = false;
            this.TB_Locname.Location = new System.Drawing.Point(13, 124);
            this.TB_Locname.Name = "TB_Locname";
            this.TB_Locname.Size = new System.Drawing.Size(270, 20);
            this.TB_Locname.TabIndex = 6;
            this.TB_Locname.Text = "Your name here";
            this.TB_Locname.TextChanged += new System.EventHandler(this.TB_Locname_TextChanged);
            // 
            // BTN_Resetloc
            // 
            this.BTN_Resetloc.Enabled = false;
            this.BTN_Resetloc.Location = new System.Drawing.Point(289, 87);
            this.BTN_Resetloc.Name = "BTN_Resetloc";
            this.BTN_Resetloc.Size = new System.Drawing.Size(47, 23);
            this.BTN_Resetloc.TabIndex = 5;
            this.BTN_Resetloc.Text = "Reset";
            this.BTN_Resetloc.UseVisualStyleBackColor = true;
            this.BTN_Resetloc.Click += new System.EventHandler(this.BTN_Resetloc_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(469, 308);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(499, 199);
            this.chart1.TabIndex = 21;
            this.chart1.TabStop = false;
            this.chart1.Text = "Ideologies";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // LBL_Tpop
            // 
            this.LBL_Tpop.AutoSize = true;
            this.LBL_Tpop.Location = new System.Drawing.Point(772, 292);
            this.LBL_Tpop.Name = "LBL_Tpop";
            this.LBL_Tpop.Size = new System.Drawing.Size(91, 13);
            this.LBL_Tpop.TabIndex = 22;
            this.LBL_Tpop.Text = "Total popularity: 0";
            // 
            // LBL_Capital
            // 
            this.LBL_Capital.AutoSize = true;
            this.LBL_Capital.Location = new System.Drawing.Point(12, 153);
            this.LBL_Capital.Name = "LBL_Capital";
            this.LBL_Capital.Size = new System.Drawing.Size(39, 13);
            this.LBL_Capital.TabIndex = 23;
            this.LBL_Capital.Text = "Capital";
            // 
            // TB_Capital
            // 
            this.TB_Capital.Location = new System.Drawing.Point(77, 150);
            this.TB_Capital.MaxLength = 6;
            this.TB_Capital.Name = "TB_Capital";
            this.TB_Capital.Size = new System.Drawing.Size(76, 20);
            this.TB_Capital.TabIndex = 7;
            this.TB_Capital.TextChanged += new System.EventHandler(this.TB_Capital_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "History Folder";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_History
            // 
            this.TB_History.Location = new System.Drawing.Point(503, 133);
            this.TB_History.Name = "TB_History";
            this.TB_History.ReadOnly = true;
            this.TB_History.Size = new System.Drawing.Size(236, 20);
            this.TB_History.TabIndex = 26;
            this.TB_History.TabStop = false;
            this.TB_History.Text = "EX: history\\countries";
            // 
            // BTN_History
            // 
            this.BTN_History.Location = new System.Drawing.Point(470, 130);
            this.BTN_History.Name = "BTN_History";
            this.BTN_History.Size = new System.Drawing.Size(27, 23);
            this.BTN_History.TabIndex = 16;
            this.BTN_History.Text = "..";
            this.BTN_History.UseVisualStyleBackColor = true;
            this.BTN_History.Click += new System.EventHandler(this.BTN_History_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Country Tags File";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Countrytags
            // 
            this.TB_Countrytags.Location = new System.Drawing.Point(503, 169);
            this.TB_Countrytags.Name = "TB_Countrytags";
            this.TB_Countrytags.ReadOnly = true;
            this.TB_Countrytags.Size = new System.Drawing.Size(236, 20);
            this.TB_Countrytags.TabIndex = 29;
            this.TB_Countrytags.TabStop = false;
            this.TB_Countrytags.Text = "EX: common\\country_tags\\00_tags.txt";
            // 
            // BTN_Countrytags
            // 
            this.BTN_Countrytags.Location = new System.Drawing.Point(470, 166);
            this.BTN_Countrytags.Name = "BTN_Countrytags";
            this.BTN_Countrytags.Size = new System.Drawing.Size(27, 23);
            this.BTN_Countrytags.TabIndex = 17;
            this.BTN_Countrytags.Text = "..";
            this.BTN_Countrytags.UseVisualStyleBackColor = true;
            this.BTN_Countrytags.Click += new System.EventHandler(this.BTN_Countrytags_Click);
            // 
            // OFD_Countrytags
            // 
            this.OFD_Countrytags.FileName = "openFileDialog1";
            this.OFD_Countrytags.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Countrytags_FileOk);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Colors File";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Colors
            // 
            this.TB_Colors.Location = new System.Drawing.Point(503, 244);
            this.TB_Colors.Name = "TB_Colors";
            this.TB_Colors.ReadOnly = true;
            this.TB_Colors.Size = new System.Drawing.Size(236, 20);
            this.TB_Colors.TabIndex = 35;
            this.TB_Colors.TabStop = false;
            this.TB_Colors.Text = "EX: common\\countries\\colors.txt";
            // 
            // BTN_Colors
            // 
            this.BTN_Colors.Location = new System.Drawing.Point(470, 241);
            this.BTN_Colors.Name = "BTN_Colors";
            this.BTN_Colors.Size = new System.Drawing.Size(27, 23);
            this.BTN_Colors.TabIndex = 19;
            this.BTN_Colors.Text = "..";
            this.BTN_Colors.UseVisualStyleBackColor = true;
            this.BTN_Colors.Click += new System.EventHandler(this.BTN_Colors_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Countries Folder";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Countries
            // 
            this.TB_Countries.Location = new System.Drawing.Point(503, 208);
            this.TB_Countries.Name = "TB_Countries";
            this.TB_Countries.ReadOnly = true;
            this.TB_Countries.Size = new System.Drawing.Size(236, 20);
            this.TB_Countries.TabIndex = 32;
            this.TB_Countries.TabStop = false;
            this.TB_Countries.Text = "EX: common\\countries";
            // 
            // BTN_Countries
            // 
            this.BTN_Countries.Location = new System.Drawing.Point(470, 205);
            this.BTN_Countries.Name = "BTN_Countries";
            this.BTN_Countries.Size = new System.Drawing.Size(27, 23);
            this.BTN_Countries.TabIndex = 18;
            this.BTN_Countries.Text = "..";
            this.BTN_Countries.UseVisualStyleBackColor = true;
            this.BTN_Countries.Click += new System.EventHandler(this.BTN_Countries_Click);
            // 
            // OFD_Colors
            // 
            this.OFD_Colors.FileName = "openFileDialog1";
            this.OFD_Colors.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Colors_FileOk);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(370, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Ideology Flags";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CD_Picker
            // 
            this.CD_Picker.FullOpen = true;
            // 
            // TB_R
            // 
            this.TB_R.Location = new System.Drawing.Point(78, 190);
            this.TB_R.MaxLength = 3;
            this.TB_R.Name = "TB_R";
            this.TB_R.Size = new System.Drawing.Size(34, 20);
            this.TB_R.TabIndex = 8;
            this.TB_R.Text = "150";
            this.TB_R.TextChanged += new System.EventHandler(this.TB_R_TextChanged);
            // 
            // TB_G
            // 
            this.TB_G.Location = new System.Drawing.Point(118, 190);
            this.TB_G.MaxLength = 3;
            this.TB_G.Name = "TB_G";
            this.TB_G.Size = new System.Drawing.Size(34, 20);
            this.TB_G.TabIndex = 9;
            this.TB_G.Text = "150";
            this.TB_G.TextChanged += new System.EventHandler(this.TB_G_TextChanged);
            // 
            // TB_B
            // 
            this.TB_B.Location = new System.Drawing.Point(158, 190);
            this.TB_B.MaxLength = 3;
            this.TB_B.Name = "TB_B";
            this.TB_B.Size = new System.Drawing.Size(34, 20);
            this.TB_B.TabIndex = 10;
            this.TB_B.Text = "150";
            this.TB_B.TextChanged += new System.EventHandler(this.TB_B_TextChanged);
            // 
            // BTN_Pick
            // 
            this.BTN_Pick.Location = new System.Drawing.Point(77, 216);
            this.BTN_Pick.Name = "BTN_Pick";
            this.BTN_Pick.Size = new System.Drawing.Size(114, 20);
            this.BTN_Pick.TabIndex = 11;
            this.BTN_Pick.Text = "Color Picker";
            this.BTN_Pick.UseVisualStyleBackColor = true;
            this.BTN_Pick.Click += new System.EventHandler(this.BTN_Pick_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Red";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Green";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Blue";
            // 
            // FBD_History
            // 
            this.FBD_History.HelpRequest += new System.EventHandler(this.FBD_History_HelpRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 47;
            this.button1.TabStop = false;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(745, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 48;
            this.button2.TabStop = false;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 49;
            this.button3.TabStop = false;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(745, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 50;
            this.button4.TabStop = false;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(745, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 23);
            this.button5.TabIndex = 51;
            this.button5.TabStop = false;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(745, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 23);
            this.button6.TabIndex = 52;
            this.button6.TabStop = false;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(745, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 23);
            this.button7.TabIndex = 56;
            this.button7.TabStop = false;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(588, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Mod Folder";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Modfolder
            // 
            this.TB_Modfolder.Location = new System.Drawing.Point(503, 22);
            this.TB_Modfolder.Name = "TB_Modfolder";
            this.TB_Modfolder.ReadOnly = true;
            this.TB_Modfolder.Size = new System.Drawing.Size(236, 20);
            this.TB_Modfolder.TabIndex = 54;
            this.TB_Modfolder.TabStop = false;
            // 
            // BTN_Modfolder
            // 
            this.BTN_Modfolder.Location = new System.Drawing.Point(470, 19);
            this.BTN_Modfolder.Name = "BTN_Modfolder";
            this.BTN_Modfolder.Size = new System.Drawing.Size(27, 23);
            this.BTN_Modfolder.TabIndex = 12;
            this.BTN_Modfolder.Text = "..";
            this.BTN_Modfolder.UseVisualStyleBackColor = true;
            this.BTN_Modfolder.Click += new System.EventHandler(this.BTN_Modfolder_Click);
            // 
            // FBD_Modfolder
            // 
            this.FBD_Modfolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FBD_Modfolder.SelectedPath = "C:\\Users\\";
            this.FBD_Modfolder.HelpRequest += new System.EventHandler(this.FBD_Modfolder_HelpRequest);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(289, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 23);
            this.button8.TabIndex = 57;
            this.button8.TabStop = false;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // BTN_Rnd
            // 
            this.BTN_Rnd.Enabled = false;
            this.BTN_Rnd.Location = new System.Drawing.Point(920, 279);
            this.BTN_Rnd.Name = "BTN_Rnd";
            this.BTN_Rnd.Size = new System.Drawing.Size(48, 23);
            this.BTN_Rnd.TabIndex = 58;
            this.BTN_Rnd.TabStop = false;
            this.BTN_Rnd.Text = "Round";
            this.BTN_Rnd.UseVisualStyleBackColor = true;
            this.BTN_Rnd.Visible = false;
            this.BTN_Rnd.Click += new System.EventHandler(this.BTN_Rnd_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(745, 279);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 23);
            this.button9.TabIndex = 62;
            this.button9.TabStop = false;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // LBL_Loc
            // 
            this.LBL_Loc.AutoSize = true;
            this.LBL_Loc.Location = new System.Drawing.Point(575, 266);
            this.LBL_Loc.Name = "LBL_Loc";
            this.LBL_Loc.Size = new System.Drawing.Size(82, 13);
            this.LBL_Loc.TabIndex = 61;
            this.LBL_Loc.Text = "Localization File";
            this.LBL_Loc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Loc
            // 
            this.TB_Loc.Location = new System.Drawing.Point(503, 282);
            this.TB_Loc.Name = "TB_Loc";
            this.TB_Loc.ReadOnly = true;
            this.TB_Loc.Size = new System.Drawing.Size(236, 20);
            this.TB_Loc.TabIndex = 60;
            this.TB_Loc.TabStop = false;
            this.TB_Loc.Text = "EX: localisation\\countries_l_english.yml";
            // 
            // BTN_Loc
            // 
            this.BTN_Loc.Location = new System.Drawing.Point(470, 279);
            this.BTN_Loc.Name = "BTN_Loc";
            this.BTN_Loc.Size = new System.Drawing.Size(27, 23);
            this.BTN_Loc.TabIndex = 20;
            this.BTN_Loc.Text = "..";
            this.BTN_Loc.UseVisualStyleBackColor = true;
            this.BTN_Loc.Click += new System.EventHandler(this.BTN_Loc_Click);
            // 
            // OFD_Loc
            // 
            this.OFD_Loc.FileName = "openFileDialog1";
            this.OFD_Loc.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Loc_FileOk);
            // 
            // BTN_Update
            // 
            this.BTN_Update.Location = new System.Drawing.Point(893, 12);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(75, 23);
            this.BTN_Update.TabIndex = 63;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = true;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 519);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.LBL_Loc);
            this.Controls.Add(this.TB_Loc);
            this.Controls.Add(this.BTN_Loc);
            this.Controls.Add(this.BTN_Rnd);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_Modfolder);
            this.Controls.Add(this.BTN_Modfolder);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BTN_Pick);
            this.Controls.Add(this.TB_B);
            this.Controls.Add(this.TB_G);
            this.Controls.Add(this.TB_R);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Colors);
            this.Controls.Add(this.BTN_Colors);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Countries);
            this.Controls.Add(this.BTN_Countries);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Countrytags);
            this.Controls.Add(this.BTN_Countrytags);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_History);
            this.Controls.Add(this.BTN_History);
            this.Controls.Add(this.TB_Capital);
            this.Controls.Add(this.LBL_Capital);
            this.Controls.Add(this.LBL_Tpop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BTN_Resetloc);
            this.Controls.Add(this.TB_Locname);
            this.Controls.Add(this.LBL_Locname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Pop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Rulingparty);
            this.Controls.Add(this.LBL_Flag);
            this.Controls.Add(this.TB_Flag);
            this.Controls.Add(this.BTN_Flag);
            this.Controls.Add(this.LBL_Ideologies);
            this.Controls.Add(this.TB_Ideologies);
            this.Controls.Add(this.BTN_ideologies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Adj);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.TB_Tag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "HOI Country Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Tag;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Adj;
        private System.Windows.Forms.Button BTN_ideologies;
        private System.Windows.Forms.TextBox TB_Ideologies;
        private System.Windows.Forms.OpenFileDialog OFD_Ideologies;
        private System.Windows.Forms.Label LBL_Ideologies;
        private System.Windows.Forms.Label LBL_Flag;
        private System.Windows.Forms.TextBox TB_Flag;
        private System.Windows.Forms.Button BTN_Flag;
        private System.Windows.Forms.OpenFileDialog OFD_Flag;
        private System.Windows.Forms.ComboBox CB_Rulingparty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Pop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Locname;
        private System.Windows.Forms.TextBox TB_Locname;
        private System.Windows.Forms.Button BTN_Resetloc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label LBL_Tpop;
        private System.Windows.Forms.Label LBL_Capital;
        private System.Windows.Forms.TextBox TB_Capital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_History;
        private System.Windows.Forms.Button BTN_History;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Countrytags;
        private System.Windows.Forms.Button BTN_Countrytags;
        private System.Windows.Forms.OpenFileDialog OFD_Countrytags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Colors;
        private System.Windows.Forms.Button BTN_Colors;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Countries;
        private System.Windows.Forms.Button BTN_Countries;
        private System.Windows.Forms.OpenFileDialog OFD_Colors;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ColorDialog CD_Picker;
        private System.Windows.Forms.TextBox TB_R;
        private System.Windows.Forms.TextBox TB_G;
        private System.Windows.Forms.TextBox TB_B;
        private System.Windows.Forms.Button BTN_Pick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FolderBrowserDialog FBD_History;
        private System.Windows.Forms.FolderBrowserDialog FBD_Countries;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_Modfolder;
        private System.Windows.Forms.Button BTN_Modfolder;
        private System.Windows.Forms.FolderBrowserDialog FBD_Modfolder;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button BTN_Rnd;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label LBL_Loc;
        private System.Windows.Forms.TextBox TB_Loc;
        private System.Windows.Forms.Button BTN_Loc;
        private System.Windows.Forms.OpenFileDialog OFD_Loc;
        private System.Windows.Forms.Button BTN_Update;
    }
}

