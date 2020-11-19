using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace Deleter.NET
{
    public partial class FormDelete : Form
    {
        FileInfo[] filesToDelete;

        public FormDelete(FileInfo[] files)
        {
            filesToDelete = files;
            InitializeComponent();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            timerDelete.Enabled = true;

            if (filesToDelete.Length == 0)
            {
                labelMessage.Text = "-  Recent files not found  -";
                labelMessage.ForeColor = Color.Red;
            }
            else
            {
                labelMessage.Text = "-  Recent files deleted  -";
                labelMessage.ForeColor = Color.Black;
            }

            try
            {
                for (int i = 0; i < filesToDelete.Length; i++)
                {
                    filesToDelete[i].Delete();
                }                
            }
            catch
            {
                MessageBox.Show("Unable to delete recent files. Check directory or try later.", "Delete Files Error", MessageBoxButtons.OK);
            }

        }

        private void timerDelete_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.01;
            if (this.Opacity < 0.0)
            {
                this.Opacity = 1;
                timerDelete.Enabled = false;
                this.Close();
            }
        }
    }
}