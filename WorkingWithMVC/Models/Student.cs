using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithMVC.Models
{
    public class Student
    {

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }



    }
}