using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyTeachingAuditProgram
{
    public class Faculty
    {

        public string JNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Faculty()
        {

        }
        public Faculty(string jnumber, string firstname, string lastname)
        {
            this.JNumber = jnumber;
            this.FirstName = firstname;
            this.LastName = lastname;
            
        }
    }
}
