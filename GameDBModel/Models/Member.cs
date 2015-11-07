using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameDBModel
{
     partial class Member
    {
        [MetadataType (typeof(MemberMeta))]
        class MemberMeta
        {
            [Display (Name= "First Name")]
            [MinLength(4, ErrorMessage= "First Name must be more than 4 characters long")]
            public string FirstName { get; set; }
            
            [Display(Name= "Last Name")]
            [MinLength(4, ErrorMessage = "Last Name must be more than 4 characters long")]
            public string LastName { get; set; }

        }
    }
}
