using System;
using System.Collections.Generic;
using Gccform.Models;

namespace Gccform.ViewModels
{
    public class EditView
    {

        public Person Persons { get; set; }
        public Address Addresses { get; set; }
        public Church Churches { get; set; }
        public Contact Contacts { get; set; }
        public PersonName PersonNames { get; set; }

    }
}
