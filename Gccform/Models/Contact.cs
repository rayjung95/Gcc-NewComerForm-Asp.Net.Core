using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Gccform.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Phone Number")]
        public string phone_num  {get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Home Number")]
        public string home_num { get; set; } 

        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
