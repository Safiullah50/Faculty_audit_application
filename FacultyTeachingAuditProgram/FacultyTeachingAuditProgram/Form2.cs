using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FacultyTeachingAuditProgram
{
    public partial class Form2 : Form
    {

        public ApprovedCourse selectedApprovedCourse = new ApprovedCourse();
        public Course selectedCourse = new Course();
        
        public Form2()
        {
            InitializeComponent();
           



        }

        

        

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>();

            string connectionstring = Connectionstring.Getconnectionstring();

            string queryString = "SELECT CourseCode, CourseTitle FROM tblCourse ORDER BY CourseCode ASC";


            try
            {

                using (OleDbConnection connection = new OleDbConnection(connectionstring))
                {
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        Course course = new Course(reader[0].ToString(), reader[1].ToString());

                        courses.Add(course);

                    }
                    reader.Close();
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
                this.Close();
            }

            

            gridViewCourseList.DataSource = courses;
            

        }



        private void btnunapprove_Click(object sender, EventArgs e)
        {
            // remove course from tblapprovedcourse by jnumber


            if (selectedApprovedCourse.JNUMBER != null)
            {
                DatabaseAccess.RemoveApproval(selectedApprovedCourse);
                gridViewApprovedCourses.DataSource = DatabaseAccess.UpdateApprovedCourseList(selectedApprovedCourse);
            }
            else
            {
                MessageBox.Show("Select a course.");
            }
        
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            // approve jnumber for course

            string jnumber = txtsearchj.Text;

            if (selectedCourse.CourseCode != null)
            {
                if (jnumber != null && jnumber.Length == 9)
                {
                    var courseToApprove = new ApprovedCourse();
                    courseToApprove.JNUMBER = jnumber;
                    courseToApprove.CourseCode = selectedCourse.CourseCode;
                    courseToApprove.DateApproved = DateTime.Now.ToString("MM/dd/yyyy");

                    var approvedCourse = DatabaseAccess.AddApproval(courseToApprove);
                    gridViewApprovedCourses.DataSource = DatabaseAccess.UpdateApprovedCourseList(approvedCourse);
                }
                else
                {
                    MessageBox.Show("Enter JagNumber");
                }
            }
            else
            {
                MessageBox.Show("Select a course.");
            }

            
        }

           
          

        private void searchJnum_Click(object sender, EventArgs e)
        {
            // show approved courses for jnumber

            string jnumber = txtsearchj.Text;
        
            string fullconnecstring = Connectionstring.Getconnectionstring();

            if (jnumber != null && jnumber.Length == 9)
            {

                List<ApprovedCourse> approvedCourses = new List<ApprovedCourse>();

                string queryString1 = "SELECT JNUMBER, CourseCode, DateApproved FROM tblApprovedCourse WHERE JNUMBER = ";
                string queryString2 = "'" + jnumber + "' ORDER BY CourseCode ASC;";
                string queryString3 = queryString1 + queryString2;

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(fullconnecstring))
                    {
                        OleDbCommand command = new OleDbCommand(queryString3, connection);
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {


                            ApprovedCourse apprcourse = new ApprovedCourse(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                            
                            DateTime date1 = Convert.ToDateTime(apprcourse.DateApproved);
                            string datestring = date1.ToShortDateString();
                            apprcourse.DateApproved = datestring;

                            approvedCourses.Add(apprcourse);

                        }
                        reader.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
                }

                gridViewApprovedCourses.DataSource = approvedCourses;


            }
            else
            {
                
                    MessageBox.Show("Enter JagNumber");
                
            }



        }

        

        private void gridViewCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridViewCourseList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridViewCourseList.Rows[e.RowIndex];

                selectedCourse.CourseCode = row.Cells["CourseCode"].Value.ToString();
                selectedCourse.CourseTitle = row.Cells["CourseTitle"].Value.ToString();

                lblcourse.Visible = true;
                lblcourse.Text = selectedCourse.CourseCode;
            }
        }

        private void gridViewApprovedCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridViewApprovedCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridViewApprovedCourses.Rows[e.RowIndex];

                selectedApprovedCourse.JNUMBER = row.Cells["JNUMBER"].Value.ToString();
                selectedApprovedCourse.CourseCode = row.Cells["CourseCode"].Value.ToString();
                selectedApprovedCourse.DateApproved = row.Cells["DateApproved"].Value.ToString();

                lblapprovecourse.Visible = true;
                lblapprovecourse.Text = selectedApprovedCourse.CourseCode;
            }
        }
    }
}
