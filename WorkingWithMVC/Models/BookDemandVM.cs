using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithMVC.Models
{
    public class BookDemandVM
    {
        public Student Student { get; set; }
        //p//rivate IList<Book>
        public IList<Book> Books { get; set; }
        public BookDemandVM()
        {
            Books = new List<Book>();
        }
    }
}