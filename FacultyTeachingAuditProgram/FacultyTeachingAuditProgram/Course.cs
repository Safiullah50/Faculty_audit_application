using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FacultyTeachingAuditProgram
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }

        public Course()
        {

        }
        public Course(string coursecode, string coursetitle  )
        {
            this.CourseCode = coursecode;
            this.CourseTitle = coursetitle;
        }
        
        

        
    }
}
