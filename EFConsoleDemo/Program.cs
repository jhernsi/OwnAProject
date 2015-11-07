using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student s = new Student();
            //s.FirstName = "John";
            //s.LastName = "Simth";

            //Student s = new Student("A", "p");

            //Student s = new Student() { FirstName = "Peter", LastName = "Simth" };


            //DBModelContainer db = new DBModelContainer();


            //db.Students.Add(new Student() { FirstName = "Rob", LastName = "Son" });
            //db.Students.Add(new Student() { FirstName = "Peter", LastName = "Stubbs" });
            //db.Students.Add(new Student(){ FirstName = "John", LastName = "Marshall" });

            //db.Courses.Add(new Course() { Code = "PROG35142", Name = "Adv .NET" });

            //db.SaveChanges();


            //using (DBModelContainer db = new DBModelContainer())
            //{

            //    //var q = from s in db.Students 
            //    //        where s.FirstName == "John" 
            //    //        select s; 

            //    //Student j = q.FirstOrDefault();

            //    Student j = (from s in db.Students
            //                 where s.FirstName == "Rob"
            //                 select s).FirstOrDefault();


            //    Course a = (from c in db.Courses
            //                where c.Code == "PROG35142"
            //                select c).FirstOrDefault();

            //    j.Courses.Add(a);
            //    //a.Students.Add(j);

            //    db.SaveChanges();
            //}

            using (DBModelContainer db = new DBModelContainer())
            {
                var queryStudent = from s in db.Students orderby s.FirstName select s;

                foreach (var s in queryStudent)
                {
                    Console.WriteLine(string.Format("{0} - {1} {2}", s.Id, s.FirstName, s.LastName));

                    var queryCourse = from c in s.Courses orderby c.Name select c;

                    foreach (var c in queryCourse)
                    {
                        Console.WriteLine(string.Format("\t\t{0} - {1}", c.Code, c.Name));
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();

        }
    }




}
