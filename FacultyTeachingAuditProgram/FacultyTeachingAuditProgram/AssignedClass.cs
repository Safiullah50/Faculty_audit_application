using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyTeachingAuditProgram
{
    public class AssignedClass
    {
        //public int AssignedClassID { get; set; }
        public string Term { get; set; }
        public string CRN { get; set; }
        public string Section { get; set; }
        public string PartTerm { get; set; }
        public string JNUMBER { get; set; }
        public string CourseCode { get; set; }

        public AssignedClass()
        {

        }
        public AssignedClass(string term, string crn, string section, string partterm, string jnumber, string coursecode)
        {
            //this.AssignedClassID = assignedclassID;
            this.Term = term;
            this.CRN = crn;
            this.Section = section;
            this.PartTerm = partterm;
            this.JNUMBER = jnumber;
            this.CourseCode = coursecode;
        }
        
    }
}
