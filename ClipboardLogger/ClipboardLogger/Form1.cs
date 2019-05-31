using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
namespace ClipboardLogger
{
    public partial class Form1 : Form
    {
        string today;
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove,
                                    IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg,
                                             IntPtr wParam,
                                             IntPtr lParam);

        IntPtr nextClipboardViewer;

        public Form1()
        {
            InitializeComponent();
            Opacity = 0;
            ShowInTaskbar = false;
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)
                         this.Handle);
            permanNotify.Visible = true;
            permanNotify.ShowBalloonTip(10);
            SetAutorunValue(true);
        }
        protected override void WndProc(ref Message m)
        {
            // defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam,
                                  m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam,
                                         m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        const string name = "Clipboard Logger";
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        private void DisplayClipboardData()
        {
            today = DateTime.Today.ToShortDateString();
            File.AppendAllText("Log" + @"\" + today + ".txt", Clipboard.GetText() + Environment.NewLine + Environment.NewLine);
            if (new DirectoryInfo(@"Log\").GetFiles().Length >= 30)
            {
                new DirectoryInfo(@"Log\").GetFileSystemInfos()
                                                                                    .OrderByDescending(fi => fi.CreationTime)
                                                                                    .Last()
                                                                                    .Delete();
            }
        }

        private void NotifyIcon_Hide(object sender, EventArgs e)
        {
            (sender as NotifyIcon).Visible = false;
        }

        private void OpenFolder(object sender, EventArgs e)
        {
            Process.Start("Log\\");
        }

        private void OpenToday(object sender, EventArgs e)
        {
            Process.Start("Log\\" + today + ".txt");
        }

        private void StopApplication(object sender, EventArgs e)
        {
            closingNotify.Visible = true;
            closingNotify.ShowBalloonTip(10);
        }

        private void ClosingNotify_BalloonTipClicked(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ClosingNotify_BalloonTipClosed(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
