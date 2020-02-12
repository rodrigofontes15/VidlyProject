using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class Customer_Dto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        //byte type field makes it implicitly mandatory. nulable byte (byte?) would not make it mandatory anymore
    
        public byte MembershipTypeId { get; set; }

    
      //  [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}
