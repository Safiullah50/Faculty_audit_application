using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyTeachingAuditProgram
{
    public class TempClass
    {
        //public int TempClassID { get; set; }
        public string Term { get; set; }
        public string CRN { get; set; }
        public string CourseCode { get; set; }
        public string Section { get; set; }                     
        public string PartTerm { get; set; }
        public string CourseTitle { get; set; }
        public string JNUMBER { get; set; }

        public TempClass()
        {

        }

        public TempClass(string term, string crn, string coursecode, string section, string partterm, string coursetitle, string jnumber)
        {
            //this.TempClassID = tempclassid;
            this.CourseCode = coursecode;
            this.CourseTitle = coursetitle;
            this.Term = term;
            this.CRN = crn;
            this.Section = section;
            this.PartTerm = partterm;
            this.JNUMBER = jnumber;
        }     

    }
}
