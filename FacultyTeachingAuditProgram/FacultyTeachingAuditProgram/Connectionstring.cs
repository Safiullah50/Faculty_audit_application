using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyTeachingAuditProgram
{
    public static class Connectionstring
    {
        // connection string format:
        // "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=databaseName;"

        // local variables
        private static string storedconnectionstring;       

        
        

        // this method returns the connection string to a form
        public static string Getconnectionstring()
        {
            FileInfo fi2 = new FileInfo("connectionstring.txt");

            using (StreamReader sr = fi2.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    storedconnectionstring = s;
                }
                sr.Close();
            }          
            
            return storedconnectionstring;
        }
    }
}
