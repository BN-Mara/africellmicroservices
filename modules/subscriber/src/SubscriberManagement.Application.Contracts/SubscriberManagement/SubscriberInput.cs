using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SubscriberManagement
{
    public abstract class SubscriberInput
    {
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public string ICCID { get; set; }
    }
}
