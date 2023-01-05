
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFGettingStarted
{ 
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }



    }
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();
            myContext.Student.Add(new Student()
            {
                StudentName = "Joe Cole",
                StudentClasses = new List<Class>()
                {
                    new Class()
                    {
                        ClassLanguage = Language.Amharic,
                        ClassName = "myFirstClass",
                    },
                    new Class()
                    {
                        ClassLanguage = Language.Franch,
                        ClassName = "mySecondClass",
                    }
                }
            };
        }
    }

}
