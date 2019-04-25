namespace FacultyTeachingAuditProgram
{
    partial class Form2
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
            this.btnunapprove = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblSearchjnum = new System.Windows.Forms.Label();
            this.txtsearchj = new System.Windows.Forms.TextBox();
            this.searchJnum = new System.Windows.Forms.Button();
            this.gridViewCourseList = new System.Windows.Forms.DataGridView();
            this.gridViewApprovedCourses = new System.Windows.Forms.DataGridView();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblApprovedCourses = new System.Windows.Forms.Label();
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblSelectedApprCourse = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblapprovecourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovedCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnunapprove
            // 
            this.btnunapprove.Location = new System.Drawing.Point(600, 454);
            this.btnunapprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnunapprove.Name = "btnunapprove";
            this.btnunapprove.Size = new System.Drawing.Size(81, 38);
            this.btnunapprove.TabIndex = 6;
            this.btnunapprove.Text = "Remove Approval";
            this.btnunapprove.UseVisualStyleBackColor = true;
            this.btnunapprove.Click += new System.EventHandler(this.btnunapprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(163, 455);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(74, 38);
            this.btnApprove.TabIndex = 8;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lblSearchjnum
            // 
            this.lblSearchjnum.AutoSize = true;
            this.lblSearchjnum.Location = new System.Drawing.Point(40, 20);
            this.lblSearchjnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchjnum.Name = "lblSearchjnum";
            this.lblSearchjnum.Size = new System.Drawing.Size(98, 13);
            this.lblSearchjnum.TabIndex = 9;
            this.lblSearchjnum.Text = "Search by Jnumber";
            // 
            // txtsearchj
            // 
            this.txtsearchj.Location = new System.Drawing.Point(153, 20);
            this.txtsearchj.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearchj.Name = "txtsearchj";
            this.txtsearchj.Size = new System.Drawing.Size(101, 20);
            this.txtsearchj.TabIndex = 10;
            // 
            // searchJnum
            // 
            this.searchJnum.Location = new System.Drawing.Point(280, 19);
            this.searchJnum.Margin = new System.Windows.Forms.Padding(2);
            this.searchJnum.Name = "searchJnum";
            this.searchJnum.Size = new System.Drawing.Size(75, 20);
            this.searchJnum.TabIndex = 13;
            this.searchJnum.Text = "Search";
            this.searchJnum.UseVisualStyleBackColor = true;
            this.searchJnum.Click += new System.EventHandler(this.searchJnum_Click);
            // 
            // gridViewCourseList
            // 
            this.gridViewCourseList.AllowUserToAddRows = false;
            this.gridViewCourseList.AllowUserToDeleteRows = false;
            this.gridViewCourseList.AllowUserToResizeColumns = false;
            this.gridViewCourseList.AllowUserToResizeRows = false;
            this.gridViewCourseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewCourseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCourseList.Location = new System.Drawing.Point(21, 88);
            this.gridViewCourseList.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewCourseList.MultiSelect = false;
            this.gridViewCourseList.Name = "gridViewCourseList";
            this.gridViewCourseList.ReadOnly = true;
            this.gridViewCourseList.RowHeadersVisible = false;
            this.gridViewCourseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewCourseList.RowTemplate.Height = 24;
            this.gridViewCourseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCourseList.Size = new System.Drawing.Size(397, 348);
            this.gridViewCourseList.TabIndex = 14;
            this.gridViewCourseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCourseList_CellContentClick);
            // 
            // gridViewApprovedCourses
            // 
            this.gridViewApprovedCourses.AllowUserToAddRows = false;
            this.gridViewApprovedCourses.AllowUserToDeleteRows = false;
            this.gridViewApprovedCourses.AllowUserToResizeColumns = false;
            this.gridViewApprovedCourses.AllowUserToResizeRows = false;
            this.gridViewApprovedCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewApprovedCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewApprovedCourses.Location = new System.Drawing.Point(445, 88);
            this.gridViewApprovedCourses.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewApprovedCourses.MultiSelect = false;
            this.gridViewApprovedCourses.Name = "gridViewApprovedCourses";
            this.gridViewApprovedCourses.ReadOnly = true;
            this.gridViewApprovedCourses.RowHeadersVisible = false;
            this.gridViewApprovedCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewApprovedCourses.RowTemplate.Height = 24;
            this.gridViewApprovedCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewApprovedCourses.Size = new System.Drawing.Size(397, 348);
            this.gridViewApprovedCourses.TabIndex = 15;
            this.gridViewApprovedCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewApprovedCourses_CellContentClick);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(75, 70);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(83, 13);
            this.lblCourses.TabIndex = 16;
            this.lblCourses.Text = "Courses Offered";
            // 
            // lblApprovedCourses
            // 
            this.lblApprovedCourses.AutoSize = true;
            this.lblApprovedCourses.Location = new System.Drawing.Point(520, 69);
            this.lblApprovedCourses.Name = "lblApprovedCourses";
            this.lblApprovedCourses.Size = new System.Drawing.Size(94, 13);
            this.lblApprovedCourses.TabIndex = 17;
            this.lblApprovedCourses.Text = "Approved Courses";
            // 
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Location = new System.Drawing.Point(40, 467);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(55, 13);
            this.lblSelectedCourse.TabIndex = 18;
            this.lblSelectedCourse.Text = "Selected: ";
            // 
            // lblSelectedApprCourse
            // 
            this.lblSelectedApprCourse.AutoSize = true;
            this.lblSelectedApprCourse.Location = new System.Drawing.Point(470, 467);
            this.lblSelectedApprCourse.Name = "lblSelectedApprCourse";
            this.lblSelectedApprCourse.Size = new System.Drawing.Size(55, 13);
            this.lblSelectedApprCourse.TabIndex = 19;
            this.lblSelectedApprCourse.Text = "Selected: ";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblcourse.Location = new System.Drawing.Point(102, 467);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(35, 13);
            this.lblcourse.TabIndex = 20;
            this.lblcourse.Text = "label1";
            this.lblcourse.Visible = false;
            // 
            // lblapprovecourse
            // 
            this.lblapprovecourse.AutoSize = true;
            this.lblapprovecourse.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblapprovecourse.Location = new System.Drawing.Point(532, 467);
            this.lblapprovecourse.Name = "lblapprovecourse";
            this.lblapprovecourse.Size = new System.Drawing.Size(35, 13);
            this.lblapprovecourse.TabIndex = 21;
            this.lblapprovecourse.Text = "label1";
            this.lblapprovecourse.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 600);
            this.Controls.Add(this.lblapprovecourse);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lblSelectedApprCourse);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.lblApprovedCourses);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.gridViewApprovedCourses);
            this.Controls.Add(this.gridViewCourseList);
            this.Controls.Add(this.searchJnum);
            this.Controls.Add(this.txtsearchj);
            this.Controls.Add(this.lblSearchjnum);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnunapprove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Teaching Audit Program";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCourseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovedCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnunapprove;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblSearchjnum;
        private System.Windows.Forms.TextBox txtsearchj;
        private System.Windows.Forms.Button searchJnum;
        private System.Windows.Forms.DataGridView gridViewCourseList;
        private System.Windows.Forms.DataGridView gridViewApprovedCourses;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblApprovedCourses;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Label lblSelectedApprCourse;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblapprovecourse;
    }
}