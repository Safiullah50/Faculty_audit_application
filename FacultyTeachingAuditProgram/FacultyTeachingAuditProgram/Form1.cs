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
using System.Data.OleDb;


namespace FacultyTeachingAuditProgram
{
    public partial class Form1 : Form
    {
        public string CsvFilePath;

        public Form1()
        {
            InitializeComponent();
        }
        

        // Get csv file path
        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            //title of the dialog box
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Tag = "Open file ";
            ofd.Filter = "type of file | *.csv" ;
            

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtbrowse.Text=ofd.FileName; // THIS IS THE FULL FILE PATH
                lblselectfile.Visible = true;
                lblnamedisplay.Visible = true;
                lblnamedisplay.Text = ofd.SafeFileName; // just shows file name

                // set file path in class variable
                CsvFilePath = ofd.FileName;
            }
        }

        // process csv
        private void btnimport_Click(object sender, EventArgs e)
        {
            // check if user browsed for the csv file
            if (CsvFilePath != null)
            {
                Form3 f3 = new Form3();
                f3.Show();

                // call method to process csv
                ProcessSpreadsheet.ProcessCSV(CsvFilePath);
                DatabaseAccess.DeleteTempClass();
                DatabaseAccess.InsertIntoTempClass();
                // update database
                DatabaseAccess.InsertNewCourses();
                DatabaseAccess.InsertNewClasses();
                DatabaseAccess.UpdateClasses();
                DatabaseAccess.DeleteTempClass();

                f3.Close();
                MessageBox.Show("Database Updated.");
            }
            else
            {
                MessageBox.Show("Select the .csv file before importing.");
            }
           
           
        }

        // First form load
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

        }

        // run audit here
        private void btnaudit_Click(object sender, EventArgs e)
        {
            // audit by term get from term text box

            string term = searchTerm.Text;

            
            

            string fullconnecstring = Connectionstring.Getconnectionstring();

            if (term != null && term.Length == 6)
            {
                List<AuditResult> auditResult = new List<AuditResult>();
                int numberfound = 0;
                
                string queryString1 = "SELECT tblAssignedClass.Term, tblAssignedClass.JNUMBER, MSTR_FAC.LASTNAME, tblCourse.CourseCode, tblCourse.CourseTitle FROM tblCourse INNER JOIN (tblAssignedClass INNER JOIN MSTR_FAC ON MID(tblAssignedClass.JNUMBER, 2, 8) = MSTR_FAC.JNUMBER) ON tblCourse.CourseCode = tblAssignedClass.CourseCode WHERE tblAssignedClass.Term =";
                string queryString2 = "'" + term + "' ";
                string queryString3 = "AND tblAssignedClass.JNUMBER & StrConv(tblAssignedClass.CourseCode, 2) NOT IN (SELECT tblApprovedCourse.JNUMBER & StrConv(tblApprovedCourse.CourseCode, 2) FROM tblApprovedCourse);";
                string queryString4 = queryString1 + queryString2 + queryString3;

                try
                {
                    using (OleDbConnection connection = new OleDbConnection(fullconnecstring))
                    {
                        OleDbCommand command = new OleDbCommand(queryString4, connection);
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            AuditResult auditrow = new AuditResult();

                            auditrow.Term = reader[0].ToString();
                            auditrow.JNUMBER = reader[1].ToString();
                            auditrow.LASTNAME = reader[2].ToString();
                            auditrow.CourseCode = reader[3].ToString();
                            auditrow.CourseTitle = reader[4].ToString();

                            auditResult.Add(auditrow);

                            numberfound++;
                        }
                        reader.Close();
                    }

                    lblnapnumber.Visible = true;
                    lblnapnumber.ForeColor = Color.Firebrick;
                    lblnapnumber.Text = numberfound.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
                }

                gridviewAudit.DataSource = auditResult;

                if (auditResult.Count < 1)
                {
                    
                    lblnapnumber.Visible = true;
                    lblnapnumber.ForeColor = Color.DarkGreen;
                    lblnapnumber.Text = "0";
                }
            }

            else
            {


                MessageBox.Show("Enter Term");

            }    

        }

        // When File Menu is opened
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        // Launch second form
        private void gotoapprov_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        // set connection string in text file
        private void connectdbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            {
                // get database file path
                OpenFileDialog ofdb = new OpenFileDialog();
                ofdb.Tag = "Select database file.";

                if (ofdb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // get path of access database
                    string dbfilepath = ofdb.FileName;
                 
                    // concatenate file path and connection string: "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=databaseName;"
                    string connecstringpart = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
                    string fullconnecstring = connecstringpart + dbfilepath + ";";

                    // open our text file to store the path
                    FileInfo f1 = new FileInfo("connectionstring.txt");

                    using (StreamWriter sw = f1.CreateText())
                    {
                        
                        // write the full connection string to our text file
                        sw.WriteLine(fullconnecstring);
                        // close file
                        sw.Close();
                    }

                    try
                    {
                        OleDbConnection myConnection = new OleDbConnection();
                        myConnection.ConnectionString = fullconnecstring;
                        myConnection.Open();
                        toolStripStatusLabel1.ForeColor = Color.Black;
                        toolStripStatusLabel1.Text = "Database Connected";
                        MessageBox.Show("Database Connected");

                        myConnection.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
                        toolStripStatusLabel1.ForeColor = Color.Red;
                        toolStripStatusLabel1.Text = "Database Disconnected";
                    }
                }
            }
        }

        // show our names here
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Young Nam Thompson \n Sayed Safiulla \n William Hale \n Andrew Whitsett", "This program was made by:");
        }

        

        // Close the Program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridviewAudit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
