using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int studentNumber { get; set; }
        public double studentDebt { get; set; }

        //public string universityDean { get; set; }
        //public string studentUnion { get; set; }
        //public DateTime happyHour { get; set; }

        //The following methods are related to a student, however, they do not define it
        //They manipulate a student and should be somewhere else
        //e.g. a StudentController or StudentService

        //public void goToLecture()
        //{

        //}

        //public void registerNewCourse(string courseName)
        //{
        //}

        //public double enrolForNewYear()
        //{
        //    return 0.0;
        //}
    }
}
