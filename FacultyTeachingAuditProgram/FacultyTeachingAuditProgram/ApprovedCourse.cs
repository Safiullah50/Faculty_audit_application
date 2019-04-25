using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyTeachingAuditProgram
{
    public class ApprovedCourse
    {
        //public int ApprovedCourseID { get; set; }
        public string JNUMBER { get; set; }
        public string CourseCode { get; set; }
        public string DateApproved { get; set; }

        public ApprovedCourse()
        {

        }
        public ApprovedCourse(string jnumber,string coursecode, string dateapproved )
        {
            //this.ApprovedCourseID = approvedcourseID;
            this.JNUMBER = jnumber;
            this.CourseCode = coursecode;
            this.DateApproved = dateapproved;
        }
        
    }
}
