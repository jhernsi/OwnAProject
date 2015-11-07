using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WorkingWithMVC.Models;

namespace WorkingWithMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public string Action1()
        {
            return "This is Action 1 in Demo Controller.";

        }

        public ActionResult Action2()
        {
            ViewBag.Title = "Demo Controller Action 2";
            ViewBag.FirstName = "Amandeep";
            ViewBag.LastName = "Patti";
            return View();
        }

        public ActionResult Action3()
        {
            return View();

        }

        public ActionResult Action4()
        {

            Student s = new Student() { FirstName = "Amandeep", LastName = "Patti" };
            return View(s);
        }


        public ActionResult Action5()
        {

            Student s1 = new Student() { FirstName = "S1 FN", LastName = "S1 LN" };
            Student s2 = new Student() { FirstName = "S2 FN", LastName = "S2 LN" };
            Student s3 = new Student() { FirstName = "S3 FN", LastName = "S3 LN" };

            //IEnumerable<Student> students = new IEnumerable<Student>();
            IList<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            
            foreach(Student s in students)
            {

            }

            return View(students);
        }
    
        public ActionResult Action6()
        {
            Student s = new Student() { FirstName = "FN1", LastName = "LN1" };
            
            Book b1 = new Book() { Title = "BT1", Author = "BA1" };
            Book b2 = new Book() { Title = "BT2", Author = "BA2" };
            Book b3 = new Book() { Title = "BT3", Author = "BA3" };

            BookDemandVM bdvm = new BookDemandVM();
            bdvm.Student = s;


            bdvm.Books.Add(b1);
            bdvm.Books.Add(b2);
            bdvm.Books.Add(b3);
            
            return View(bdvm);
        }

    }
}








