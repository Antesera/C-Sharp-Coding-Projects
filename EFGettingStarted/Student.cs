using System;
using System.Collections.Generic;
using System.Text;

namespace EFGettingStarted
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public List<Class> StudentClass { get; set }
    }
}
