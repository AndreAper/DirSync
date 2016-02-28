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

namespace DirSync
{
    public partial class frmMain : Form
    {
        string sourceDir, destDir;
        TimeSpan time;
        bool overwrite;

        void Copy()
        {
            if (sourceDir.Length != 0)
            {
                if (destDir.Length != 0)
                {
                    foreach (string file in Directory.EnumerateFiles(sourceDir))
                    {
                        FileInfo fi = new FileInfo(file);
                        try
                        {
                            fi.CopyTo(Path.Combine(destDir, fi.Name), overwrite);
                        }
                        catch (Exception e)
                        {
                            if (e.HResult == -2147024816)
                            {
                                return;
                            }
                            else
                            {
                                throw;
                            }
                        }
                    }  
                }
            }
        }

        void UpdateForm()
        {
            tbxSourceFolder.Text = sourceDir;
            tbxDestFolder.Text = destDir;
            dtpTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, time.Hours, time.Minutes, time.Seconds);
            chkBxOverwrite.Checked = overwrite;
        }

        void UpdateSettings()
        {
            Properties.Settings.Default.SourceFolder = sourceDir;
            Properties.Settings.Default.DestFolder = destDir;
            Properties.Settings.Default.Time = time;
            Properties.Settings.Default.Save();
        }

        public frmMain()
        {
            InitializeComponent();

            sourceDir = Properties.Settings.Default.SourceFolder;
            destDir = Properties.Settings.Default.DestFolder;
            time = Properties.Settings.Default.Time;
            overwrite = Properties.Settings.Default.Overwrite;

            UpdateForm();
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select destination folder";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                destDir = fbd.SelectedPath;
                UpdateForm();
            }

            
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan tsNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            if (TimeSpan.Compare(tsNow, time) == 0)
            {
                Copy();
            }
        }

        private void chkBtnEnabled_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectSource.Enabled = !chkBtnEnabled.Checked;
            btnSelectDest.Enabled = !chkBtnEnabled.Checked;
            tbxSourceFolder.Enabled = !chkBtnEnabled.Checked;
            tbxDestFolder.Enabled = !chkBtnEnabled.Checked;
            dtpTime.Enabled = !chkBtnEnabled.Checked;

            if (chkBtnEnabled.Checked)
            {
                time = new TimeSpan(dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);

                chkBtnEnabled.Text = "Enabled";
                chkBtnEnabled.BackColor = Color.GreenYellow;
                chkBtnEnabled.ForeColor = Color.Black;

                UpdateSettings();
            }
            else
            {
                chkBtnEnabled.Text = "Disabled";
                chkBtnEnabled.BackColor = Color.Crimson;
                chkBtnEnabled.ForeColor = Color.White;
            }
        }

        private void chkBxOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            overwrite = chkBxOverwrite.Checked;
            UpdateSettings();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select source folder";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowNewFolderButton = false;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sourceDir = fbd.SelectedPath;
                UpdateForm();
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
