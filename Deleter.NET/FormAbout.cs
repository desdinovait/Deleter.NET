using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Deleter.NET
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            //Titolo
            labelProductName.Text = Assembly.GetExecutingAssembly().GetName(false).Name.ToString() + " " + Assembly.GetExecutingAssembly().GetName(false).Version.ToString();

            linkLabel1.Links.Remove(linkLabel1.Links[0]);
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "http://www.desdinova.it/");
        }
    }
}