using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace Gccform.Models
{
    public class PersonName
    {
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string k_fname { get; set; } 
        [StringLength(100, MinimumLength = 1)]
        public string k_lname { get; set; } 
        [StringLength(100, MinimumLength = 1)]
        public string e_fname { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string e_lname { get; set; } 

        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
