using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        //no need for functionality of list class, like adding, removing, accesing by index. ienureble only iterates. If we replace list with another collection, as long collection implements ienumerable 
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit " + Customer.Name;

                return "New Customer";
            }
        }
    }
}