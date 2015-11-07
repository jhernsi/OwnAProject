using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApp
{
    public partial class Student
    {

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", 
                                FirstName, LastName); ;
            }
        }


    }
}
