using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyTeachingAuditProgram
{
    public static class ProcessSpreadsheet
    {
        public static void ProcessCSV(string csvFilePath)
        {
            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                // Read and display lines from the file until the end of 
                // the file is reached.

                string line;
                // List to hold csv lines
                List<string> classList = new List<string>();
                // List to hold columns we need
                List<string> classList7 = new List<string>();
                // List to hold final values
                List<string> finalclasslist = new List<string>();


                FileInfo f1 = new FileInfo("testfile.txt");
                StreamWriter sw = f1.CreateText();

                while ((line = sr.ReadLine()) != null)
                {
                    classList.Add(line);

                    


                } // end readline loop

                // only add columns we need
                foreach(string row in classList)
                {
                    // delimiter
                    char[] chars = new char[1];
                    chars[0] = ',';

                    String[] splitline = row.Split(chars);

                    // "Term""CRN""Course""Sec""Part Term""Course Title""ID"
                    // "201910""12556""CIS010""101""1""Computer Proficiency Exam" "J00168099"

                    string tempstring = splitline[1] + "," + splitline[2] + "," + splitline[5] + "," + splitline[6] + "," +
                        splitline[7] + "," + splitline[12] + "," + splitline[15];

                    classList7.Add(tempstring);

                    // testfile.txt
                    sw.WriteLine(tempstring);

                }

                
                

                //close testfile.txt
                sw.Close();
                
                // write needed data to new file
                FileInfo f3 = new FileInfo("finalschedule.txt");
                StreamWriter sw3 = f3.CreateText();

                // skip first line to avoid column names, put in new list

                for (int i = 1; i < classList7.Count; i++)
                {
                    finalclasslist.Add(classList7[i]);

                    sw3.WriteLine(classList7[i]);
                }

                // close finalschedule.txt
                sw3.Close();

                // close streamreader
                sr.Close();

            } // using streamreader end

            //MessageBox.Show("Schedule Imported.");
        }
    }
}
