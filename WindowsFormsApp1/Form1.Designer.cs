namespace WindowsFormsApp1
{
    partial class Zsizsinstall
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
            this.Installoptions = new System.Windows.Forms.CheckedListBox();
            this.Install_List = new System.Windows.Forms.ListBox();
            this.isntallstart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Installoptions
            // 
            this.Installoptions.CheckOnClick = true;
            this.Installoptions.FormattingEnabled = true;
            this.Installoptions.Items.AddRange(new object[] {
            "Outlook",
            "Directx",
            "Appshare"});
            this.Installoptions.Location = new System.Drawing.Point(12, 12);
            this.Installoptions.Name = "Installoptions";
            this.Installoptions.ScrollAlwaysVisible = true;
            this.Installoptions.Size = new System.Drawing.Size(567, 289);
            this.Installoptions.TabIndex = 0;
            //this.Installoptions.SelectedIndexChanged += new System.EventHandler(this.Installoptions_SelectedIndexChanged);
            // 
            // Install_List
            // 
            this.Install_List.FormattingEnabled = true;
            this.Install_List.Location = new System.Drawing.Point(585, 12);
            this.Install_List.Name = "Install_List";
            this.Install_List.Size = new System.Drawing.Size(195, 264);
            this.Install_List.TabIndex = 1;
            // 
            // isntallstart
            // 
            this.isntallstart.Location = new System.Drawing.Point(585, 278);
            this.isntallstart.Name = "isntallstart";
            this.isntallstart.Size = new System.Drawing.Size(195, 23);
            this.isntallstart.TabIndex = 2;
            this.isntallstart.Text = "Install item(s)";
            this.isntallstart.UseVisualStyleBackColor = true;
            this.isntallstart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Zsizsinstall
            // 
            this.ClientSize = new System.Drawing.Size(786, 314);
            this.Controls.Add(this.isntallstart);
            this.Controls.Add(this.Install_List);
            this.Controls.Add(this.Installoptions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Zsizsinstall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Zsizsinstall_Load);
            this.ResumeLayout(false);

        }

        private void Installoptions_SelectedIndexChanged(object sender) //System.Eventargs e)
        {
           // throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox Installoptions;
        private System.Windows.Forms.ListBox Install_List;
        private System.Windows.Forms.Button isntallstart;
    }
}