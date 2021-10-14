using System;

namespace POS_console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    FirstName = "Jack",
                    LastName = "Andersen"
                };

                var crs = new Course()
                {
                    CourseName = "DatabaseProgrammering"
                };

                context.Students.Add(std);
                context.Courses.Add(crs);
                context.SaveChanges();
            }
        }
    }
}