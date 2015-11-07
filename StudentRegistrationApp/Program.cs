using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;

            do
            {
                Console.Clear();
                op = GetUserOption();
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Bye");
                        break;

                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        AddCourse();
                        break;

                    case 3:
                        DisplayAllStudents();
                        break;
                    case 4:
                        DisplayAllCourses();
                        break;

                    case 5:
                        AddStudentToCourse();
                        break;
                    case 6:
                        AssignCourseToStudent();
                        break;


                    default:
                        Console.WriteLine("Wrong Option, Please Retry...");
                        break;
                }


                Console.ReadKey();

            } while (op != 0);


        }

        private static void AssignCourseToStudent()
        {
            throw new NotImplementedException();
        }

        private static void AddStudentToCourse()
        {
            
            using (DBModelContainer context = new DBModelContainer())
            {
                Console.WriteLine("Student Registration Number: ");
                string srn = Console.ReadLine();

                Student student =( from s in context.Students
                            where s.Number == srn
                            select s).FirstOrDefault();
                if (student != null)
                {
                    DisplayStudent(student);

                    Console.WriteLine("Course Code: ");
                    string cc = Console.ReadLine();

                    Course course = (from c in context.Courses
                                       where c.Code == cc
                                       select c).FirstOrDefault();
                    if(course !=null)
                    {
                        DisplayCourse(course);

                        student.Courses.Add(course);
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Course Code.");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Student Registration Number.");
                }

            }


        }

        private static void DisplayCourse(Course course)
        {
            Console.WriteLine(string.Format("{0} - {1}", course.Code, course.Name));
        }

        private static void DisplayStudent(Student student)
        {
            Console.WriteLine(string.Format("{0} - {1}",student.Number, student.Name));
        }

        private static void DisplayAllCourses()
        {
            using (DBModelContainer context = new DBModelContainer())
            {
                var query = from c in context.Courses
                            select c;


                foreach (Course course in query)
                {
                    DisplayCourse(course);
                    foreach (Student student in course.Students)
                    {
                        DisplayStudent(student);
                    }
                }
            }
        }

        private static void DisplayAllStudents()
        {
            using (DBModelContainer context = new DBModelContainer())
            {
                var query = from s in context.Students
                            select s;

                //List<Student> students = new List<Student>();
                //students = query.ToList();

                foreach (Student student in query)
                {
                    DisplayStudent(student);

                    foreach (Course course in student.Courses)
                    {
                        DisplayCourse(course);
                    }
                }


            }
        }

        private static int GetUserOption()
        {
            int op;
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");

            Console.WriteLine("3. Display Students");
            Console.WriteLine("4. Display Courses");

            Console.WriteLine("5. Add Student to Course");
            Console.WriteLine("6. Assign Course to Student");


            Console.WriteLine();
            Console.Write("Enter your option: ");
            op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        private static void AddStudent()
        {
            using (DBModelContainer context = new DBModelContainer())
            {
                Student s = new Student();

                Console.Write("Student First Name: ");
                s.FirstName = Console.ReadLine();

                Console.Write("Student Last Name: ");
                s.LastName = Console.ReadLine();

                Console.Write("Student Registration Number: ");
                s.Number = Console.ReadLine();

                context.Students.Add(s);
                context.SaveChanges();

            }


        }

        private static void AddCourse()
        {
            using (DBModelContainer context = new DBModelContainer())
            {
                Course c = new Course();

                Console.Write("Course Code: ");
                c.Code = Console.ReadLine();

                Console.Write("Cousre Name: ");
                c.Name = Console.ReadLine();

                context.Courses.Add(c);
                context.SaveChanges();

            }
        }
    }
}
