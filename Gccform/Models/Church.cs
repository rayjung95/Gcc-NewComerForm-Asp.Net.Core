using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Gccform.Models
{
    public class Church
    {
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string vehicle_license { get; set; }
        public DateTime baptized_date { get; set; } 
        [StringLength(100, MinimumLength = 1)]
        public string baptized_church { get; set; } 
        [StringLength(100, MinimumLength = 1)]
        public string infant_baptized_church { get; set; }
        public DateTime infant_baptized_date { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string person_status { get; set; } 
        [StringLength(100, MinimumLength = 1)]
        public string position_type { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string last_church_name { get; set; } 
        [StringLength(100, MinimumLength = 1)]
        public string last_church_leader { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string friends_in_church { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string volunteer_experience { get; set; } 

        public int PersonID { get; set; }
        public Person Person { get; set; }

    }
}
