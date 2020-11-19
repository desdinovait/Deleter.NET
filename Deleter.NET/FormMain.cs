using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace Deleter.NET
{

    public partial class FormMain : Form
    {
        public FileInfo[] files = new FileInfo[0];
        public DirectoryInfo currentRecentPathInfo;
        public string currentRecentPath = "";

        public FormMain()
        {
            InitializeComponent();
        }

        public void SaveRegistry()
        {
            RegistryKey OurKeyStatup = Registry.CurrentUser;
            OurKeyStatup = OurKeyStatup.OpenSubKey("Software", true);
            OurKeyStatup = OurKeyStatup.CreateSubKey("Deleter.NET");

            if (checkDeleteStartup.Checked == true)
            {
                OurKeyStatup.SetValue("DeleteAtStartup", 1, RegistryValueKind.DWord);
            }
            else
            {
                OurKeyStatup.SetValue("DeleteAtStartup", 0, RegistryValueKind.DWord);
            }
        }

        public void PopulateList()
        {
            files = currentRecentPathInfo.GetFiles("*.lnk");
            listRecent.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                listRecent.Items.Add(files[i].ToString());
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Assembly.GetExecutingAssembly().GetName(false).Name.ToString() + " " + Assembly.GetExecutingAssembly().GetName(false).Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName(false).Version.Minor.ToString();

            RegistryKey OurKey = Registry.CurrentUser;
            OurKey = OurKey.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders", true);
            currentRecentPath = labelRecent.Text = OurKey.GetValue("Recent").ToString();
            fileWatcher.Path = currentRecentPath;
            currentRecentPathInfo = new DirectoryInfo(currentRecentPath);
            
            try
            {
                RegistryKey OurKeyStatup = Registry.CurrentUser;
                OurKeyStatup = OurKeyStatup.OpenSubKey("Software\\Deleter.NET", true);
                if (OurKeyStatup.GetValue("DeleteAtStartup").ToString() == "1")
                {
                    checkDeleteStartup.Checked = true;
                }
                else
                {
                    checkDeleteStartup.Checked = false;
                }
            }
            catch
            {
                checkDeleteStartup.Checked = false;
            }

            PopulateList();

            if (checkDeleteStartup.Checked == true)
            {
                DeleteProcedure();
            }

            this.Visible = false;

        }

        private bool DeleteProcedure()
        {
            try
            {
                if (files.Length == 0)
                {
                    notifyRecent.ShowBalloonTip(1500, "Deleter.NET", "Recent files NOT found. Deletion skipped.", ToolTipIcon.Warning);
                    return false;
                }
                else
                {
                    int counter = 0;
                    for (int i = 0; i < files.Length; i++)
                    {
                        try
                        {
                            files[i].Delete();
                            counter = counter + 1;
                        }
                        catch
                        {
                        }
                    }
                    if (counter == 1)
                        notifyRecent.ShowBalloonTip(1500, "Deleter.NET", counter.ToString() + " recent file deleted correctly.", ToolTipIcon.Info);
                    else
                        notifyRecent.ShowBalloonTip(1500, "Deleter.NET", counter.ToString() + " recent files deleted correctly.", ToolTipIcon.Info);
                    return true;
                }
            }
            catch
            {
                return false;
            }

            //Or use:
            //FormDelete delete = new FormDelete(files);
            //delete.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            SaveRegistry();
            Application.Exit();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyRecent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DeleteProcedure();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (this.Visible == false)
                {
                    this.Show();
                    this.Focus();
                }
                else
                {
                    this.Hide();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteProcedure();
        }

        private void fileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            PopulateList();
        }

        private void listRecent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FileInfo toDelete = new FileInfo( currentRecentPath + "\\" + listRecent.Items[listRecent.SelectedIndices[0]].Text.ToString());
            toDelete.Delete();          
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (listRecent.SelectedIndices.Count > 0)
            {
                try
                {
                    Process.Start(currentRecentPath + "\\" + listRecent.Items[listRecent.SelectedIndices[0]].Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Unable to open selected recent file.","File Error",MessageBoxButtons.OK);
                }
            }
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(currentRecentPath);
            }
            catch
            {
                MessageBox.Show("Unable to open recent files directory.", "File Error", MessageBoxButtons.OK);
            }
        }


        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout aboutMe = new FormAbout();
            aboutMe.ShowDialog(); 
        }

        private void FormMain_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
            }

            if ((e.CloseReason == CloseReason.TaskManagerClosing) || (e.CloseReason == CloseReason.ApplicationExitCall) || (e.CloseReason == CloseReason.WindowsShutDown))
            {
                //Esce
                SaveRegistry();
                e.Cancel = false;
            }
        }
    }
}