using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace Gccform.Models
{
    public class Person
    {
        
        public int ID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public DateTime dob { get; set; } 

        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Email")]
        public string email { get; set; } 

        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Job Title")]
        public string job { get; set; }

        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Company Name")]
        public string company_name { get; set; }

        //public List<Address> Addresses { get; set; }
        //public List<Church> Churches { get; set; }
        //public List<Contact> Contacts { get; set; }
        //public List<PersonName> PersonNames { get; set; }

        public ICollection<Contact> Contacts { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Church> Churches { get; set; }
        public ICollection<PersonName> PersonNames { get; set; }



        //[StringLength(100, MinimumLength = 1)]
        //public string phone_num  {get; set; }
        //[StringLength(100, MinimumLength = 1)]
        //public string home_num { get; set; } 


        //[StringLength(100, MinimumLength = 1)]
        //public string street1 { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string street2 { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string city { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string postal_code { get; set; }


        //[StringLength(100, MinimumLength = 1)]
        //public string k_fname { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string k_lname { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string e_fname { get; set; }
        //[StringLength(100, MinimumLength = 1)]
        //public string e_lname { get; set; } 


        //[StringLength(100, MinimumLength = 1)]
        //public string vehicle_license { get; set; }
        //public DateTime baptized_date { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string baptized_church { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string infant_baptized_church { get; set; }
        //public DateTime infant_baptized_date { get; set; }
        //[StringLength(100, MinimumLength = 1)]
        //public string person_status { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string position_type { get; set; }
        //[StringLength(100, MinimumLength = 1)]
        //public string last_church_name { get; set; } 
        //[StringLength(100, MinimumLength = 1)]
        //public string last_church_leader { get; set; }
        //[StringLength(100, MinimumLength = 1)]
        //public string friends_in_church { get; set; }
        //[StringLength(100, MinimumLength = 1)]
        //public string volunteer_experience { get; set; } 









    }
}
