using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Gccform.Models
{
    public class Address
    {
        
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string street1 { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string street2 { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string city { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string postal_code { get; set; }

        public int PersonID { get; set; }
        public Person Person { get; set; }


    }
}
