using System;
using System.Threading;
using System.Windows.Forms;

namespace LeagueOverwolfLauncher
{
    public partial class MainForm : Form
    {
        Thread AutoLaunchThread;
        private delegate void SafeCallDelegateVisibility();
        private delegate void SafeCallDelegateProgress(int value);
        private delegate void SafeCallDelegateLabel(string text, bool clear);

        public MainForm()
        {
            InitializeComponent();
            this.TopMost = false;

            ThreadLaunch threadLaunch = new ThreadLaunch(this);

            label_informations.Text = "Autorun starting";
            AutoLaunchThread = new Thread(threadLaunch.AutoLaunch);
            AutoLaunchThread.Start();
        }

        private void Button4_StopThread_Click(object sender, EventArgs e)
        {
            StopThread();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            if (StopThread())
                Environment.Exit(0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/RekklesLoL");
        }

        private bool StopThread()
        {
            if (AutoLaunchThread.IsAlive)
            {
                AutoLaunchThread.Abort();
                button4_StopThread.Visible = false;
                button4_StopThread.Enabled = false;
                label_informations.Text = "AutoRun Stopped";
            }
            return true;
        }

        public void UpdateVisibility()
        {
            if (button4_StopThread.InvokeRequired)
            {
                SafeCallDelegateVisibility d = new SafeCallDelegateVisibility(UpdateVisibility);
                button4_StopThread.Invoke(d, new object[] {});
            }
            else
            {
                button4_StopThread.Visible = false;
                button4_StopThread.Enabled = false;
                button_quit.Visible = false;
                button_quit.Enabled = false;
                progressBar_loading.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        public void UpdateProgressBar(int value)
        {
            if (progressBar_loading.InvokeRequired)
            {
                SafeCallDelegateProgress d = new SafeCallDelegateProgress(UpdateProgressBar);
                progressBar_loading.Invoke(d, new object[] { value });
            }
            else
            {
                progressBar_loading.Value = value;
            }
        }

        public void UpdateLabel(string text, bool clear)
        {
            if (label_informations.InvokeRequired)
            {
                SafeCallDelegateLabel d = new SafeCallDelegateLabel(UpdateLabel);
                label_informations.Invoke(d, new object[] { text, clear });
            }
            else
            {
                if (clear)
                    label_informations.Text = text;
                else
                    label_informations.Text += "\n" + text;
            }
        }

        public void UpdateMessage(string text, int value)
        {
            UpdateLabel(text, false);
            UpdateProgressBar(value);
        }
    }
}
