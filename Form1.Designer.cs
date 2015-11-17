namespace Sakura_Clicker_1._2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrGameCheck = new System.Windows.Forms.Timer(this.components);
            this.clickCountUpdate = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chromeForm1 = new ChromeForm();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.checkBoxOnTop = new ChromeCheckbox();
            this.checkBoxSaveConfig = new ChromeCheckbox();
            this.processNameTXT = new System.Windows.Forms.TextBox();
            this.processNameLBL = new System.Windows.Forms.Label();
            this.checkBoxCustomWindow = new ChromeCheckbox();
            this.chromeButton1 = new ChromeButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cpsLBL = new System.Windows.Forms.Label();
            this.clickLBL = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNudeAdjust = new ChromeCheckbox();
            this.checkBoxWindowCheck = new ChromeCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBindKey = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioToggle = new ChromeRadioButton();
            this.radioHold = new ChromeRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalTB = new System.Windows.Forms.TrackBar();
            this.statusLBL = new System.Windows.Forms.Label();
            this.chromeForm1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalTB)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGameCheck
            // 
            this.tmrGameCheck.Interval = 1000;
            this.tmrGameCheck.Tick += new System.EventHandler(this.tmrGameCheck_Tick);
            // 
            // clickCountUpdate
            // 
            this.clickCountUpdate.Enabled = true;
            this.clickCountUpdate.Interval = 1;
            this.clickCountUpdate.Tick += new System.EventHandler(this.clickCountUpdate_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Click the icon to return to advanced style";
            this.notifyIcon.BalloonTipTitle = "Sakura clicker";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sakura clicker is working";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.label3);
            this.chromeForm1.Controls.Add(this.cbStyle);
            this.chromeForm1.Controls.Add(this.checkBoxOnTop);
            this.chromeForm1.Controls.Add(this.checkBoxSaveConfig);
            this.chromeForm1.Controls.Add(this.processNameTXT);
            this.chromeForm1.Controls.Add(this.processNameLBL);
            this.chromeForm1.Controls.Add(this.checkBoxCustomWindow);
            this.chromeForm1.Controls.Add(this.chromeButton1);
            this.chromeForm1.Controls.Add(this.groupBox3);
            this.chromeForm1.Controls.Add(this.groupBox2);
            this.chromeForm1.Controls.Add(this.label2);
            this.chromeForm1.Controls.Add(this.btnBindKey);
            this.chromeForm1.Controls.Add(this.groupBox1);
            this.chromeForm1.Controls.Add(this.label1);
            this.chromeForm1.Controls.Add(this.intervalTB);
            this.chromeForm1.Controls.Add(this.statusLBL);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = true;
            this.chromeForm1.Sizable = false;
            this.chromeForm1.Size = new System.Drawing.Size(201, 438);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "Sakura Clicker";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Style";
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Advanced",
            "Simple"});
            this.cbStyle.Location = new System.Drawing.Point(8, 591);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 23);
            this.cbStyle.TabIndex = 16;
            this.cbStyle.Text = "Advanced";
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.cbStyle_SelectedIndexChanged);
            // 
            // checkBoxOnTop
            // 
            this.checkBoxOnTop.Checked = false;
            this.checkBoxOnTop.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.checkBoxOnTop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxOnTop.Image = null;
            this.checkBoxOnTop.Location = new System.Drawing.Point(9, 525);
            this.checkBoxOnTop.Name = "checkBoxOnTop";
            this.checkBoxOnTop.NoRounding = false;
            this.checkBoxOnTop.Size = new System.Drawing.Size(110, 17);
            this.checkBoxOnTop.TabIndex = 0;
            this.checkBoxOnTop.Text = "Always on top";
            this.checkBoxOnTop.Transparent = false;
            this.checkBoxOnTop.CheckedChanged += new ChromeCheckbox.CheckedChangedEventHandler(this.checkBoxOnTop_CheckedChanged);
            // 
            // checkBoxSaveConfig
            // 
            this.checkBoxSaveConfig.Checked = false;
            this.checkBoxSaveConfig.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.checkBoxSaveConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxSaveConfig.Image = null;
            this.checkBoxSaveConfig.Location = new System.Drawing.Point(9, 548);
            this.checkBoxSaveConfig.Name = "checkBoxSaveConfig";
            this.checkBoxSaveConfig.NoRounding = false;
            this.checkBoxSaveConfig.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSaveConfig.TabIndex = 15;
            this.checkBoxSaveConfig.Text = "Save settings";
            this.checkBoxSaveConfig.Transparent = false;
            this.checkBoxSaveConfig.CheckedChanged += new ChromeCheckbox.CheckedChangedEventHandler(this.checkBoxSaveConfig_CheckedChanged);
            // 
            // processNameTXT
            // 
            this.processNameTXT.Enabled = false;
            this.processNameTXT.Location = new System.Drawing.Point(9, 478);
            this.processNameTXT.Name = "processNameTXT";
            this.processNameTXT.Size = new System.Drawing.Size(178, 23);
            this.processNameTXT.TabIndex = 14;
            this.processNameTXT.TextChanged += new System.EventHandler(this.processNameTXT_TextChanged);
            // 
            // processNameLBL
            // 
            this.processNameLBL.AutoSize = true;
            this.processNameLBL.Enabled = false;
            this.processNameLBL.Location = new System.Drawing.Point(9, 460);
            this.processNameLBL.Name = "processNameLBL";
            this.processNameLBL.Size = new System.Drawing.Size(154, 15);
            this.processNameLBL.TabIndex = 13;
            this.processNameLBL.Text = "Process name (e.g. \"Skype\")";
            // 
            // checkBoxCustomWindow
            // 
            this.checkBoxCustomWindow.Checked = false;
            this.checkBoxCustomWindow.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.checkBoxCustomWindow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxCustomWindow.Image = null;
            this.checkBoxCustomWindow.Location = new System.Drawing.Point(12, 440);
            this.checkBoxCustomWindow.Name = "checkBoxCustomWindow";
            this.checkBoxCustomWindow.NoRounding = false;
            this.checkBoxCustomWindow.Size = new System.Drawing.Size(160, 17);
            this.checkBoxCustomWindow.TabIndex = 11;
            this.checkBoxCustomWindow.Text = "Use custom gamewindow";
            this.checkBoxCustomWindow.Transparent = false;
            this.checkBoxCustomWindow.CheckedChanged += new ChromeCheckbox.CheckedChangedEventHandler(this.checkBoxCustomWindow_CheckedChanged);
            // 
            // chromeButton1
            // 
            this.chromeButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.chromeButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chromeButton1.Image = null;
            this.chromeButton1.Location = new System.Drawing.Point(12, 419);
            this.chromeButton1.Name = "chromeButton1";
            this.chromeButton1.NoRounding = false;
            this.chromeButton1.Size = new System.Drawing.Size(178, 15);
            this.chromeButton1.TabIndex = 10;
            this.chromeButton1.Text = "Open settings";
            this.chromeButton1.Transparent = false;
            this.chromeButton1.Click += new System.EventHandler(this.chromeButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cpsLBL);
            this.groupBox3.Controls.Add(this.clickLBL);
            this.groupBox3.Location = new System.Drawing.Point(12, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 63);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // cpsLBL
            // 
            this.cpsLBL.AutoSize = true;
            this.cpsLBL.Location = new System.Drawing.Point(6, 37);
            this.cpsLBL.Name = "cpsLBL";
            this.cpsLBL.Size = new System.Drawing.Size(111, 15);
            this.cpsLBL.TabIndex = 2;
            this.cpsLBL.Text = "Clicks per second: 1";
            // 
            // clickLBL
            // 
            this.clickLBL.AutoSize = true;
            this.clickLBL.Location = new System.Drawing.Point(6, 19);
            this.clickLBL.Name = "clickLBL";
            this.clickLBL.Size = new System.Drawing.Size(50, 15);
            this.clickLBL.TabIndex = 0;
            this.clickLBL.Text = "Clicks: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNudeAdjust);
            this.groupBox2.Controls.Add(this.checkBoxWindowCheck);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 69);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game related";
            // 
            // chkNudeAdjust
            // 
            this.chkNudeAdjust.Checked = false;
            this.chkNudeAdjust.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.chkNudeAdjust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkNudeAdjust.Image = null;
            this.chkNudeAdjust.Location = new System.Drawing.Point(7, 46);
            this.chkNudeAdjust.Name = "chkNudeAdjust";
            this.chkNudeAdjust.NoRounding = false;
            this.chkNudeAdjust.Size = new System.Drawing.Size(160, 17);
            this.chkNudeAdjust.TabIndex = 1;
            this.chkNudeAdjust.Text = "Adjust for nude patch";
            this.chkNudeAdjust.Transparent = false;
            this.chkNudeAdjust.CheckedChanged += new ChromeCheckbox.CheckedChangedEventHandler(this.chkNudeAdjust_CheckedChanged);
            // 
            // checkBoxWindowCheck
            // 
            this.checkBoxWindowCheck.Checked = false;
            this.checkBoxWindowCheck.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
            this.checkBoxWindowCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBoxWindowCheck.Image = null;
            this.checkBoxWindowCheck.Location = new System.Drawing.Point(7, 23);
            this.checkBoxWindowCheck.Name = "checkBoxWindowCheck";
            this.checkBoxWindowCheck.NoRounding = false;
            this.checkBoxWindowCheck.Size = new System.Drawing.Size(160, 17);
            this.checkBoxWindowCheck.TabIndex = 0;
            this.checkBoxWindowCheck.Text = "Check for game\'s window";
            this.checkBoxWindowCheck.Transparent = false;
            this.checkBoxWindowCheck.CheckedChanged += new ChromeCheckbox.CheckedChangedEventHandler(this.checkBoxWindowCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trigger key";
            // 
            // btnBindKey
            // 
            this.btnBindKey.BackColor = System.Drawing.Color.White;
            this.btnBindKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBindKey.Location = new System.Drawing.Point(15, 152);
            this.btnBindKey.Name = "btnBindKey";
            this.btnBindKey.Size = new System.Drawing.Size(50, 23);
            this.btnBindKey.TabIndex = 0;
            this.btnBindKey.Text = "C";
            this.btnBindKey.UseVisualStyleBackColor = false;
            this.btnBindKey.Click += new System.EventHandler(this.btnBindKey_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioToggle);
            this.groupBox1.Controls.Add(this.radioHold);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clicking trigger method";
            // 
            // radioToggle
            // 
            this.radioToggle.Checked = false;
            this.radioToggle.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            this.radioToggle.Field = 16;
            this.radioToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioToggle.Image = null;
            this.radioToggle.Location = new System.Drawing.Point(7, 46);
            this.radioToggle.Name = "radioToggle";
            this.radioToggle.NoRounding = false;
            this.radioToggle.Size = new System.Drawing.Size(71, 16);
            this.radioToggle.TabIndex = 1;
            this.radioToggle.Text = "Toggle";
            this.radioToggle.Transparent = false;
            this.radioToggle.CheckedChanged += new ChromeRadioButton.CheckedChangedEventHandler(this.radioToggle_CheckedChanged);
            // 
            // radioHold
            // 
            this.radioHold.Checked = false;
            this.radioHold.Customization = "PDw8/+3t7f/m5ub/p6en/2RkZP8=";
            this.radioHold.Field = 16;
            this.radioHold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.radioHold.Image = null;
            this.radioHold.Location = new System.Drawing.Point(7, 23);
            this.radioHold.Name = "radioHold";
            this.radioHold.NoRounding = false;
            this.radioHold.Size = new System.Drawing.Size(59, 16);
            this.radioHold.TabIndex = 0;
            this.radioHold.Text = "Hold";
            this.radioHold.Transparent = false;
            this.radioHold.CheckedChanged += new ChromeRadioButton.CheckedChangedEventHandler(this.radioHold_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clicks per second";
            // 
            // intervalTB
            // 
            this.intervalTB.Location = new System.Drawing.Point(12, 91);
            this.intervalTB.Maximum = 1000;
            this.intervalTB.Minimum = 1;
            this.intervalTB.Name = "intervalTB";
            this.intervalTB.Size = new System.Drawing.Size(137, 45);
            this.intervalTB.TabIndex = 2;
            this.intervalTB.TickFrequency = 100;
            this.intervalTB.Value = 1;
            this.intervalTB.Scroll += new System.EventHandler(this.intervalTB_Scroll);
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.Location = new System.Drawing.Point(12, 40);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(64, 15);
            this.statusLBL.TabIndex = 1;
            this.statusLBL.Text = "Status: idle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 438);
            this.Controls.Add(this.chromeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sakura Clicker";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        private System.Windows.Forms.TrackBar intervalTB;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.GroupBox groupBox2;
        private ChromeCheckbox checkBoxWindowCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBindKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private ChromeRadioButton radioToggle;
        private ChromeRadioButton radioHold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label clickLBL;
        private System.Windows.Forms.Timer tmrGameCheck;
        private System.Windows.Forms.Label cpsLBL;
        private ChromeCheckbox chkNudeAdjust;
        private ChromeCheckbox checkBoxOnTop;
        private System.Windows.Forms.TextBox processNameTXT;
        private System.Windows.Forms.Label processNameLBL;
        private ChromeCheckbox checkBoxCustomWindow;
        private ChromeCheckbox checkBoxSaveConfig;
        private ChromeButton chromeButton1;
        private System.Windows.Forms.Timer clickCountUpdate;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStyle;
    }
}

