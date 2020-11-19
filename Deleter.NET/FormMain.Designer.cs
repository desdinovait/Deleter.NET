namespace Deleter.NET
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRecent = new System.Windows.Forms.Label();
            this.checkDeleteStartup = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listRecent = new System.Windows.Forms.ListView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.notifyRecent = new System.Windows.Forms.NotifyIcon(this.components);
            this.fileWatcher = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRecent);
            this.groupBox1.Controls.Add(this.checkDeleteStartup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options :";
            // 
            // labelRecent
            // 
            this.labelRecent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRecent.Location = new System.Drawing.Point(6, 31);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(277, 19);
            this.labelRecent.TabIndex = 1;
            this.labelRecent.Text = "\\\\";
            this.labelRecent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkDeleteStartup
            // 
            this.checkDeleteStartup.AutoSize = true;
            this.checkDeleteStartup.Location = new System.Drawing.Point(6, 59);
            this.checkDeleteStartup.Name = "checkDeleteStartup";
            this.checkDeleteStartup.Size = new System.Drawing.Size(202, 17);
            this.checkDeleteStartup.TabIndex = 2;
            this.checkDeleteStartup.Text = "Deleter recent files at program startup";
            this.checkDeleteStartup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows recent files path :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFolder);
            this.groupBox2.Controls.Add(this.buttonExecute);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listRecent);
            this.groupBox2.Location = new System.Drawing.Point(6, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recent files :";
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(6, 303);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(87, 24);
            this.buttonFolder.TabIndex = 2;
            this.buttonFolder.Text = "Open Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(99, 303);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(87, 24);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete All Recent files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listRecent
            // 
            this.listRecent.Location = new System.Drawing.Point(7, 20);
            this.listRecent.MultiSelect = false;
            this.listRecent.Name = "listRecent";
            this.listRecent.Size = new System.Drawing.Size(179, 247);
            this.listRecent.TabIndex = 0;
            this.listRecent.UseCompatibleStateImageBehavior = false;
            this.listRecent.View = System.Windows.Forms.View.List;
            this.listRecent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRecent_MouseDoubleClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(204, 407);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 23);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(204, 378);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(91, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(204, 349);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(91, 23);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // notifyRecent
            // 
            this.notifyRecent.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyRecent.Icon")));
            this.notifyRecent.Text = "Deleter.NET";
            this.notifyRecent.Visible = true;
            this.notifyRecent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyRecent_MouseClick);
            // 
            // fileWatcher
            // 
            this.fileWatcher.EnableRaisingEvents = true;
            this.fileWatcher.Filter = "*.lnk";
            this.fileWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileWatcher.SynchronizingObject = this;
            this.fileWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileWatcher_Deleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 437);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleter.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Closing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listRecent;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.CheckBox checkDeleteStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyRecent;
        private System.Windows.Forms.Label labelRecent;
        private System.IO.FileSystemWatcher fileWatcher;
    }
}

