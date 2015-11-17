using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowsInput;
using System.Threading;
using System.Drawing;
using System.IO;
using Ini;

namespace Sakura_Clicker_1._2
{
    public partial class Form1 : Form
    {
        #region imports
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        #endregion


        public Form1()
        {
            InitializeComponent();
            radioHold.Checked = true;
            var thread = new Thread(ClickShit) {IsBackground = true};
            thread.Start();
        }

        #region global_vars
        private bool checkWindow;
        private bool clicking;
        private bool keyPressed;
        private bool triggerKeyPressed;
        private bool nudePatchUsed;
        private bool windowOnTop;
        private bool settingsOpened;
        private bool customGameWindow;
        private bool saveSettings;
        private string processName;
        private int triggerType = 1;
        private int interval = 1000;
        private int chosenStyle; //0 - advanced, 1 - simple
        private string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\sakuraClicker.ini";
        private Int64 totalClicks;
        private IntPtr gameHandle = IntPtr.Zero;
        private Keys key = Keys.C;
        private InputSimulator input = new InputSimulator();
        #endregion

        private void btnBindKey_Click(object sender, EventArgs e)
        {
            btnBindKey.Text = "";
            statusLBL.Text = "Status: press a key to bind";
            keyPressed = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyPressed)
            {
                key = e.KeyCode;
                btnBindKey.Text = key.ToString();
                statusLBL.Text = "Status: idle";
                keyPressed = false;
            }

        }

        private void tmrGameCheck_Tick(object sender, System.EventArgs e)
        {
            Process[] process;

            if (checkWindow && !nudePatchUsed && !customGameWindow)
            {
                try
                {
                    process = Process.GetProcessesByName("Tap Dungeon");
                    if (process.Length > 0)
                        gameHandle = process[0].MainWindowHandle;
                }
                catch { }
            }

            else if (checkWindow && nudePatchUsed && !customGameWindow)
            {
                try
                {
                    process = Process.GetProcessesByName("Sakura Clicker");
                    if (process.Length > 0)
                        gameHandle = process[0].MainWindowHandle;
                }
                catch { }
            }

            else if (checkWindow && customGameWindow)
            {
                try
                {
                    process = Process.GetProcessesByName(processName);
                    if (process.Length > 0)
                        gameHandle = process[0].MainWindowHandle;
                }
                catch { }
            }

        }

        private void intervalTB_Scroll(object sender, System.EventArgs e)
        {
            interval = 1000/intervalTB.Value;
            cpsLBL.Text = "Clicks per second: " + intervalTB.Value;
        }

        private void radioHold_CheckedChanged(object sender)
        {
            triggerType = 1;
        }

        private void radioToggle_CheckedChanged(object sender)
        {
            triggerType = 2;
        }

        private void checkBoxWindowCheck_CheckedChanged(object sender)
        {
            checkWindow = !checkWindow;
            if (checkWindow)
                tmrGameCheck.Start();
            else
                tmrGameCheck.Stop();
        }

        private void ClickShit()
        {
            while (true)
            {
                if (triggerType == 1)
                {
                    if (GetAsyncKeyState(key) != 0 && !clicking)
                        clicking = true;
                    else
                        if (GetAsyncKeyState(key) == 0 && clicking)
                            clicking = false;
                }

                if (triggerType == 2)
                {
                    if (GetAsyncKeyState(key) == 0)
                    {
                        triggerKeyPressed = false;
                    }
                    if (GetAsyncKeyState(key) != 0 && !clicking && !triggerKeyPressed)
                    {
                            triggerKeyPressed = true;
                            clicking = true;
                    }
                    if (GetAsyncKeyState(key) != 0 && clicking && !triggerKeyPressed)
                    {
                        triggerKeyPressed = true;
                        clicking = false;
                    }
                }

                if (clicking && checkWindow)
                {
                    if (GetForegroundWindow() == gameHandle)
                    {
                        input.Mouse.LeftButtonDown();
                        Thread.Sleep(interval);
                        input.Mouse.LeftButtonUp();
                        totalClicks++;
                    }
                    else
                        clicking = false;
                }
                else if (clicking)
                {
                    input.Mouse.LeftButtonDown();
                    Thread.Sleep(interval);
                    input.Mouse.LeftButtonUp();
                    totalClicks++;
                }
            }
        }

        private void chkNudeAdjust_CheckedChanged(object sender)
        {
            nudePatchUsed = !nudePatchUsed;
        }

        private void checkBoxOnTop_CheckedChanged(object sender)
        {
            windowOnTop = !windowOnTop;

            if (windowOnTop)
                TopMost = true;
            else
                TopMost = false;
        }

        private void chromeButton1_Click(object sender, EventArgs e)
        {
            //201, 511
            settingsOpened = !settingsOpened;

            if (settingsOpened)
            {
                Size = new Size(201, 626);
                chromeButton1.Text = "Hide settings";
            }
            else
            {
                Size = new Size(201, 438);
                chromeButton1.Text = "Open settings";
            }
        }

        private void checkBoxCustomWindow_CheckedChanged(object sender)
        {
            customGameWindow = !customGameWindow;

            if (customGameWindow)
            {
                processNameLBL.Enabled = true;
                processNameTXT.Enabled = true;
            }
            else
            {
                processNameLBL.Enabled = false;
                processNameTXT.Enabled = false;
            }
        }

        private void processNameTXT_TextChanged(object sender, EventArgs e)
        {
            processName = processNameTXT.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveSettings)
                saveConfig();
        }

        private void checkBoxSaveConfig_CheckedChanged(object sender)
        {
            saveSettings = !saveSettings;
        }

        private void saveConfig()
        {
            IniFile ini = new IniFile(savePath);

            ini.IniWriteValue("Clicking", "Clicks per second", intervalTB.Value.ToString());
            ini.IniWriteValue("Clicking", "Trigger key", key.ToString());
            ini.IniWriteValue("Clicking", "Trigger method", triggerType.ToString());

            ini.IniWriteValue("Window", "Check for game window", checkWindow.ToString().ToLower());
            ini.IniWriteValue("Window", "Adjust for nude patch", nudePatchUsed.ToString().ToLower());
            ini.IniWriteValue("Window", "Custom game window", customGameWindow.ToString().ToLower());
            ini.IniWriteValue("Window", "Process name", processName);

            ini.IniWriteValue("Settings", "Always on top", windowOnTop.ToString().ToLower());
            ini.IniWriteValue("Settings", "Save settings", saveSettings.ToString().ToLower());
            ini.IniWriteValue("Settings", "Style", chosenStyle.ToString());
        }

        private void loadConfig()
        {
            IniFile ini = new IniFile(savePath);

            intervalTB.Value = int.Parse(ini.IniReadValue("Clicking", "Clicks per second"));
            key = (Keys)Enum.Parse(typeof(Keys), ini.IniReadValue("Clicking", "Trigger key"));
            triggerType = int.Parse(ini.IniReadValue("Clicking", "Trigger method"));
            checkWindow = Convert.ToBoolean(ini.IniReadValue("Window", "Check for game window"));
            nudePatchUsed = Convert.ToBoolean(ini.IniReadValue("Window", "Adjust for nude patch"));
            customGameWindow = Convert.ToBoolean(ini.IniReadValue("Window", "Custom game window"));
            processName = ini.IniReadValue("Window", "Process name");
            windowOnTop = Convert.ToBoolean(ini.IniReadValue("Settings", "Always on top"));
            saveSettings = Convert.ToBoolean(ini.IniReadValue("Settings", "Save settings"));
            chosenStyle = int.Parse(ini.IniReadValue("Settings", "Style"));

            btnBindKey.Text = key.ToString();

            if (triggerType == 1)
                radioHold.Checked = true;
            else
                radioToggle.Checked = true;

            if (checkWindow)
            {
                checkBoxWindowCheck.Checked = true;
                tmrGameCheck.Start();
            }
            else
                checkBoxWindowCheck.Checked = false;

            if (nudePatchUsed)
                chkNudeAdjust.Checked = true;
            else
                chkNudeAdjust.Checked = false;

            if (customGameWindow)
            {
                checkBoxCustomWindow.Checked = true;
                processNameLBL.Enabled = true;
                processNameTXT.Enabled = true;
                processNameTXT.Text = processName;
            }
            else
            {
                checkBoxCustomWindow.Checked = false;
                processNameLBL.Enabled = false;
                processNameTXT.Enabled = false;
            }

            if (windowOnTop)
            {
                checkBoxOnTop.Checked = true;
                TopMost = true;
            }
            else
            {
                checkBoxOnTop.Checked = false;
                TopMost = false;
            }

            if (saveSettings)
                checkBoxSaveConfig.Checked = true;
            else
                checkBoxSaveConfig.Checked = false;

            interval = 1000 / intervalTB.Value;
            cpsLBL.Text = "Clicks per second: " + intervalTB.Value;

            switch(chosenStyle)
            {
                case 0:
                    {
                        cbStyle.Text = "Advanced";
                        Size = new Size(201, 438);
                        statusLBL.Visible = true;
                        statusLBL.Location = new Point(12, 40);
                        label1.Location = new Point(12, 73);
                        intervalTB.Location = new Point(12, 91);
                        label2.Location = new Point(15, 133);
                        btnBindKey.Location = new Point(15, 152);
                        groupBox1.Location = new Point(12, 191);
                        this.Size = new Size(200, 438);
                        clickCountUpdate.Start();
                        notifyIcon.Visible = false;
                        break;
                    }
                case 1:
                    {
                        cbStyle.Text = "Simple";
                        checkWindow = false;
                        nudePatchUsed = false;
                        customGameWindow = false;
                        processName = "";
                        settingsOpened = false;
                        chromeButton1.Text = "Open settings";
                        chosenStyle = 1;
                        clickCountUpdate.Stop();
                        tmrGameCheck.Stop();
                        statusLBL.Visible = false;
                        label1.Location = new Point(12, 40);
                        intervalTB.Location = new Point(12, 58);
                        label2.Location = new Point(12, 95);
                        btnBindKey.Location = new Point(12, 114);
                        groupBox1.Location = new Point(12, 149);
                        this.Size = new Size(201, 234);
                        notifyIcon.Visible = true;
                        notifyIcon.ShowBalloonTip(3000);
                        break;
                    }
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(savePath))
            {
                loadConfig();
                this.StartPosition = FormStartPosition.Manual;
                this.Location = PointToScreen(new Point(0, 0));
            }
        }

        private void clickCountUpdate_Tick(object sender, EventArgs e)
        {
            if (clicking && !keyPressed)
            {
                statusLBL.Text = "Status: clicking";
                clickLBL.Text = "Clicks: " + totalClicks;
            }
            else if (!keyPressed)
                statusLBL.Text = "Status: idle";
            if (clicking && checkWindow && !(GetForegroundWindow() == gameHandle))
            {
                statusLBL.Text = "Status: idle";
                clicking = false;
            }
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStyle.Text == "Simple")
            {
                cbStyle.Text = "Simple";
                checkWindow = false;
                nudePatchUsed = false;
                customGameWindow = false;
                processName = "";
                settingsOpened = false;
                chromeButton1.Text = "Open settings";
                chosenStyle = 1;
                checkBoxWindowCheck.Checked = false;
                chkNudeAdjust.Checked = false;
                checkBoxCustomWindow.Checked = false;
                clickCountUpdate.Stop();
                tmrGameCheck.Stop();
                statusLBL.Visible = false;
                label1.Location = new Point(12, 40);
                intervalTB.Location = new Point(12, 58);
                label2.Location = new Point(12, 95);
                btnBindKey.Location = new Point(12, 114);
                groupBox1.Location = new Point(12, 149);
                this.Size = new Size(201, 234);
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(3000);
            }
            else        
                chosenStyle = 0;
            
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            cbStyle.Text = "Advanced";
            Size = new Size(201, 438);
            statusLBL.Visible = true;
            statusLBL.Location = new Point(12, 40);
            label1.Location = new Point(12, 73);
            intervalTB.Location = new Point(12, 91);
            label2.Location = new Point(15, 133);
            btnBindKey.Location = new Point(15, 152);
            groupBox1.Location = new Point(12, 191);
            this.Size = new Size(200, 438);
            clickCountUpdate.Start();
            notifyIcon.Visible = false;
        }
    }
}