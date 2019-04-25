using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace FacultyTeachingAuditProgram
{
    public static class DatabaseAccess
    {
        // database operations

        public static void TestMethod()
        {
            MessageBox.Show("Hello there.");
        }

        public static void DeleteTempClass()
        {
            //clear tblTempClass
            string deleteString = "DELETE * FROM tblTempClass; ";

            string connectionstring = Connectionstring.Getconnectionstring();

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {

                OleDbCommand command = new OleDbCommand(deleteString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }

        public static void Select()
        {
            // not using


            string connectionstring = Connectionstring.Getconnectionstring();

            string queryString = "SELECT CourseCode FROM tblCourse";

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
                reader.Close();
            }

            

        }

        public static List<Course> SelectCourses()
        {
            // not using
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

            catch(Exception ex)
            {
                MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
                
            }

            return courses;

        }

        

        public static void InsertIntoTempClass()
        {
            List<TempClass> tempClasses = new List<TempClass>();

            // read finalschedule.txt into list

            using (StreamReader sr = new StreamReader("finalschedule.txt"))
            {
                string line;
                
                while ((line = sr.ReadLine()) != null)
                {
                    
                    char[] chars = new char[1];
                    chars[0] = ',';

                    String[] splitline = line.Split(chars);

                    TempClass tempclass = new TempClass(splitline[0], splitline[1], splitline[2], splitline[3], splitline[4], splitline[5], splitline[6]);

                    // FILTER OUT ROWS WITH EMPTY JNUMBERS
                    if(splitline[6].Length > 2)
                    {
                        tempClasses.Add(tempclass);
                    }
                    
                    

                }

            } // end streamreader  

            // send to method for database inserts
            populatetblTempClass(tempClasses);
        }

        private static void populatetblTempClass(List<TempClass> classes)
        {
            string connectionstring = Connectionstring.Getconnectionstring();

            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                

                // insert into tblTempClass

                foreach (TempClass oneclass in classes)
                {
                    try
                    {
                        connection.ConnectionString = connectionstring;
                        OleDbCommand command = new OleDbCommand();
                        command.CommandType = System.Data.CommandType.Text;

                        string insertTerm = oneclass.Term;
                        string insertCRN = oneclass.CRN;
                        string insertCourseCode = oneclass.CourseCode;
                        string insertSection = oneclass.Section;
                        string insertPartTerm = oneclass.PartTerm;
                        string insertCourseTitle = oneclass.CourseTitle;
                        string insertJNUMBER = oneclass.JNUMBER;

                        command.CommandText = "INSERT INTO [tblTempClass] ( [Term], [CRN], [CourseCode], [Section], [PartTerm], [CourseTitle], [JNUMBER])" +
                            "VALUES (?, ?, ?, ?, ?, ?, ?)";

                        command.Parameters.AddWithValue("Term", insertTerm);
                        command.Parameters.AddWithValue("CRN", insertCRN);
                        command.Parameters.AddWithValue("CourseCode", insertCourseCode);
                        command.Parameters.AddWithValue("Section", insertSection);
                        command.Parameters.AddWithValue("PartTerm", insertPartTerm);
                        command.Parameters.AddWithValue("CourseTitle", insertCourseTitle);
                        command.Parameters.AddWithValue("JNUMBER", insertJNUMBER);

                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                }

                



            }

            
        }

        
        public static void InsertNewCourses()
        {
            // insert into tblCourse
            string fullconnecstring = Connectionstring.Getconnectionstring();
            try
            {

                OleDbConnection myConnection = new OleDbConnection();
                myConnection.ConnectionString = fullconnecstring;
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "INSERT INTO tblcourse (CourseCode, CourseTitle) SELECT DISTINCT(CourseCode), MAX(CourseTitle) FROM tblTempClass WHERE CourseCode NOT IN (SELECT CourseCode FROM tblCourse) GROUP BY CourseCode;";
                command.Connection = myConnection;
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();


            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.ToString());
            }
        }

        

        public static void InsertNewClasses()
        {
            
            List<AssignedClass> tempClasses = new List<AssignedClass>();
            List<AssignedClass> databaseAssignedClasses = new List<AssignedClass>();
            List<AssignedClass> classesToAdd = new List<AssignedClass>();

            string fullconnecstring = Connectionstring.Getconnectionstring();

            //string querygettempclasses = "SELECT tblTempClass.Term, tblTempClass.CRN, tblTempClass.CourseCode, tblTempClass.Section, tblTempClass.PartTerm, tblTempClass.JNUMBER FROM tblTempClass;"; // won't read
            string querygettempclasses2 = "SELECT * FROM tblTempClass;";

            // get temp classes
            try
            {
                using (OleDbConnection connection = new OleDbConnection(fullconnecstring))
                {
                    OleDbCommand command = new OleDbCommand(querygettempclasses2, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        
                        AssignedClass assignedClass = new AssignedClass();
                        assignedClass.Term = reader[1].ToString();
                        assignedClass.CRN = reader[2].ToString();
                        assignedClass.CourseCode = reader[3].ToString();
                        assignedClass.Section = reader[4].ToString();
                        assignedClass.PartTerm = reader[5].ToString();
                        assignedClass.JNUMBER = reader[7].ToString();


                        tempClasses.Add(assignedClass);

                    }
                    reader.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
            }

            // get database list of classes

            try
            {
                string querygetdatabaseclasses = "SELECT * FROM tblAssignedClass;";

                using (OleDbConnection connection = new OleDbConnection(fullconnecstring))
                {
                    OleDbCommand command = new OleDbCommand(querygetdatabaseclasses, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        AssignedClass assignedClass = new AssignedClass();
                        assignedClass.Term = reader[1].ToString();
                        assignedClass.CRN = reader[2].ToString();
                        assignedClass.Section = reader[3].ToString();
                        assignedClass.PartTerm = reader[4].ToString();
                        assignedClass.JNUMBER = reader[5].ToString();
                        assignedClass.CourseCode = reader[6].ToString();  

                        databaseAssignedClasses.Add(assignedClass);

                    }
                    reader.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("OLEDB Connection FAILED: " + ex.Message);
            }

            // compare to make new insert list

            int testnum = 0;
            foreach(var tclass in tempClasses)
            {
                int matchnum = 0;

                foreach (var aclass in databaseAssignedClasses)
                {
                    //string tclassstring = tclass.Term + tclass.CRN + tclass.Section + tclass.PartTerm + tclass.JNUMBER + tclass.CourseCode;
                    //string aclassstring = aclass.Term + aclass.CRN + aclass.Section + aclass.PartTerm + aclass.JNUMBER + aclass.CourseCode;

                    string tclassstring = tclass.Term + tclass.CRN + tclass.Section;
                    string aclassstring = aclass.Term + aclass.CRN + aclass.Section;

                    if (tclassstring == aclassstring)
                    {
                        matchnum++;
                        break; // end loop if match is found
                    }
                }

                if (matchnum < 1) // add if no matches
                {
                    classesToAdd.Add(tclass);
                    testnum++;
                }
            }
            Console.WriteLine(testnum.ToString());

            // insert into tblAssignedClass

            using (OleDbConnection connection = new OleDbConnection(fullconnecstring))
            {


                

                foreach (var oneclass in classesToAdd)
                {
                    try
                    {
                        connection.ConnectionString = fullconnecstring;
                        OleDbCommand command = new OleDbCommand();
                        command.CommandType = System.Data.CommandType.Text;

                        string insertTerm = oneclass.Term;
                        string insertCRN = oneclass.CRN;
                        string insertSection = oneclass.Section;
                        string insertPartTerm = oneclass.PartTerm;
                        string insertJNUMBER = oneclass.JNUMBER;
                        string insertCourseCode = oneclass.CourseCode;
                        

                        command.CommandText = "INSERT INTO [tblAssignedClass] ( [Term], [CRN], [Section], [PartTerm], [JNUMBER], [CourseCode])" +
                            "VALUES (?, ?, ?, ?, ?, ?)";

                        command.Parameters.AddWithValue("Term", insertTerm);
                        command.Parameters.AddWithValue("CRN", insertCRN);
                        command.Parameters.AddWithValue("Section", insertSection);
                        command.Parameters.AddWithValue("PartTerm", insertPartTerm);
                        command.Parameters.AddWithValue("JNUMBER", insertJNUMBER);
                        command.Parameters.AddWithValue("CourseCode", insertCourseCode);

                        command.Connection = connection;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex);
                    }
                }

            }

        }

        public static void UpdateClasses()
        {
            // update tblAssignedClass
            string fullconnecstring = Connectionstring.Getconnectionstring();
            try
            {
                OleDbConnection myConnection = new OleDbConnection();
                myConnection.ConnectionString = fullconnecstring;
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "UPDATE tblAssignedClass INNER JOIN tblTempClass ON (tblAssignedClass.Section = tblTempClass.Section) AND (tblAssignedClass.Term = tblTempClass.Term) AND (tblAssignedClass.CRN = tblTempClass.CRN) SET tblAssignedClass.JNUMBER = [tblTempClass].[JNUMBER];";
                command.Connection = myConnection;
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.ToString());
            }
        }

        public static void RemoveApproval(ApprovedCourse course)
        {
            string fullconnecstring = Connectionstring.Getconnectionstring();
            try
            {

                OleDbConnection myConnection = new OleDbConnection();
                myConnection.ConnectionString = fullconnecstring;
                //string deleteJNUMBER = course.JNUMBER;
                //string deleteCourseCode = course.CourseCode;

                string deleteString = "DELETE FROM tblApprovedCourse WHERE JNUMBER = " + "'" + course.JNUMBER + "' " + "AND CourseCode = " + "'" + course.CourseCode + "';";

                OleDbCommand command = new OleDbCommand(deleteString, myConnection);

                command.Connection = myConnection;
                myConnection.Open();

                command.ExecuteNonQuery();
                myConnection.Close();


            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                //close the connection

                MessageBox.Show("Error:" + exp.ToString());

            }
        }
        public static List<ApprovedCourse> UpdateApprovedCourseList(ApprovedCourse course)
        {
            string jnumber = course.JNUMBER;

            string fullconnecstring = Connectionstring.Getconnectionstring();

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

            return approvedCourses;

        }

        public static ApprovedCourse AddApproval(ApprovedCourse courseToApprove)
        {
            string fullconnecstring = Connectionstring.Getconnectionstring();
            try
            {

                OleDbConnection myConnection = new OleDbConnection();
                myConnection.ConnectionString = fullconnecstring;
                OleDbCommand command = new OleDbCommand();

                
                string addString = "INSERT INTO tblApprovedCourse (JNUMBER, CourseCode, DateApproved) VALUES" + "('" + courseToApprove.JNUMBER + "','" + courseToApprove.CourseCode +
                    "','" + courseToApprove.DateApproved + "');";

                command.CommandText = addString;
                command.Connection = myConnection;
                myConnection.Open();
                command.ExecuteNonQuery();
                myConnection.Close();


            }
            catch (System.Data.OleDb.OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.ToString());
            }

            return courseToApprove;
        }

        

    } // end DatabaseAccess class
} // end namespace
