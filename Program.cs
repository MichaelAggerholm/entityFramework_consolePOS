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
                    Name = "Jack"
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
