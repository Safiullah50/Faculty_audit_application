
namespace FacultyTeachingAuditProgram
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
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtbrowse = new System.Windows.Forms.TextBox();
            this.lblselectfile = new System.Windows.Forms.Label();
            this.lblnamedisplay = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnaudit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectdbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoapprov = new System.Windows.Forms.Button();
            this.gridviewAudit = new System.Windows.Forms.DataGridView();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblauditlist = new System.Windows.Forms.Label();
            this.lblnapnumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAudit)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(100, 60);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(56, 19);
            this.btnbrowse.TabIndex = 0;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click_1);
            // 
            // txtbrowse
            // 
            this.txtbrowse.Location = new System.Drawing.Point(175, 60);
            this.txtbrowse.Margin = new System.Windows.Forms.Padding(2);
            this.txtbrowse.Name = "txtbrowse";
            this.txtbrowse.Size = new System.Drawing.Size(292, 20);
            this.txtbrowse.TabIndex = 1;
            // 
            // lblselectfile
            // 
            this.lblselectfile.AutoSize = true;
            this.lblselectfile.Location = new System.Drawing.Point(141, 106);
            this.lblselectfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselectfile.Name = "lblselectfile";
            this.lblselectfile.Size = new System.Drawing.Size(138, 13);
            this.lblselectfile.TabIndex = 2;
            this.lblselectfile.Text = "Name Of The Selected file :";
            // 
            // lblnamedisplay
            // 
            this.lblnamedisplay.AutoSize = true;
            this.lblnamedisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblnamedisplay.Location = new System.Drawing.Point(283, 106);
            this.lblnamedisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnamedisplay.Name = "lblnamedisplay";
            this.lblnamedisplay.Size = new System.Drawing.Size(35, 13);
            this.lblnamedisplay.TabIndex = 3;
            this.lblnamedisplay.Text = "label2";
            this.lblnamedisplay.Visible = false;
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(206, 133);
            this.btnimport.Margin = new System.Windows.Forms.Padding(2);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(102, 22);
            this.btnimport.TabIndex = 4;
            this.btnimport.Text = "Import csv";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnaudit
            // 
            this.btnaudit.Location = new System.Drawing.Point(253, 433);
            this.btnaudit.Margin = new System.Windows.Forms.Padding(2);
            this.btnaudit.Name = "btnaudit";
            this.btnaudit.Size = new System.Drawing.Size(76, 37);
            this.btnaudit.TabIndex = 6;
            this.btnaudit.Text = "Audit";
            this.btnaudit.UseVisualStyleBackColor = true;
            this.btnaudit.Click += new System.EventHandler(this.btnaudit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectdbToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // connectdbToolStripMenuItem
            // 
            this.connectdbToolStripMenuItem.Name = "connectdbToolStripMenuItem";
            this.connectdbToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.connectdbToolStripMenuItem.Text = "Connect to database";
            this.connectdbToolStripMenuItem.Click += new System.EventHandler(this.connectdbToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gotoapprov
            // 
            this.gotoapprov.Location = new System.Drawing.Point(376, 433);
            this.gotoapprov.Margin = new System.Windows.Forms.Padding(2);
            this.gotoapprov.Name = "gotoapprov";
            this.gotoapprov.Size = new System.Drawing.Size(110, 37);
            this.gotoapprov.TabIndex = 8;
            this.gotoapprov.Text = "Go to Approvals";
            this.gotoapprov.UseVisualStyleBackColor = true;
            this.gotoapprov.Click += new System.EventHandler(this.gotoapprov_Click);
            // 
            // gridviewAudit
            // 
            this.gridviewAudit.AllowUserToAddRows = false;
            this.gridviewAudit.AllowUserToDeleteRows = false;
            this.gridviewAudit.AllowUserToResizeColumns = false;
            this.gridviewAudit.AllowUserToResizeRows = false;
            this.gridviewAudit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridviewAudit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewAudit.Location = new System.Drawing.Point(12, 160);
            this.gridviewAudit.Name = "gridviewAudit";
            this.gridviewAudit.ReadOnly = true;
            this.gridviewAudit.RowHeadersVisible = false;
            this.gridviewAudit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridviewAudit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridviewAudit.Size = new System.Drawing.Size(536, 249);
            this.gridviewAudit.TabIndex = 10;
            this.gridviewAudit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewAudit_CellContentClick);
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(112, 442);
            this.searchTerm.Margin = new System.Windows.Forms.Padding(2);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(118, 20);
            this.searchTerm.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Term:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lblauditlist
            // 
            this.lblauditlist.AutoSize = true;
            this.lblauditlist.Location = new System.Drawing.Point(25, 141);
            this.lblauditlist.Name = "lblauditlist";
            this.lblauditlist.Size = new System.Drawing.Size(75, 13);
            this.lblauditlist.TabIndex = 13;
            this.lblauditlist.Text = "Not approved:";
            // 
            // lblnapnumber
            // 
            this.lblnapnumber.AutoSize = true;
            this.lblnapnumber.ForeColor = System.Drawing.Color.Firebrick;
            this.lblnapnumber.Location = new System.Drawing.Point(107, 141);
            this.lblnapnumber.Name = "lblnapnumber";
            this.lblnapnumber.Size = new System.Drawing.Size(35, 13);
            this.lblnapnumber.TabIndex = 14;
            this.lblnapnumber.Text = "label2";
            this.lblnapnumber.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 517);
            this.Controls.Add(this.lblnapnumber);
            this.Controls.Add(this.lblauditlist);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.gridviewAudit);
            this.Controls.Add(this.gotoapprov);
            this.Controls.Add(this.btnaudit);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.lblnamedisplay);
            this.Controls.Add(this.lblselectfile);
            this.Controls.Add(this.txtbrowse);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Teaching Audit Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewAudit)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtbrowse;
        private System.Windows.Forms.Label lblselectfile;
        private System.Windows.Forms.Label lblnamedisplay;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnaudit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectdbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button gotoapprov;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridviewAudit;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblauditlist;
        private System.Windows.Forms.Label lblnapnumber;
    }
}

