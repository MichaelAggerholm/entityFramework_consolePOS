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
                    FirstName = "Jackson",
                    LastName = "Andersenville"
                };

                var crs = new Course()
                {
                    CourseName = "Ottododo"
                };

                context.Students.Add(std);
                context.Courses.Add(crs);
                context.SaveChanges();
            }
        }
    }
}