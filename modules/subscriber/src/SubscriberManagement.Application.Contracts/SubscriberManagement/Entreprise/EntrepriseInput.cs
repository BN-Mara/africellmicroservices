using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SubscriberManagement
{
    public class EntrepriseInput:SubscriberInput
    {
        
        [Required]
        public string NationalId { get; set; }
        [Required]
        public string EntrepriseName { get; set; }
        [Required]
        public string Responsible { get; set; }
        [Required]
        public string LegalForm { get; set; }
    }
}
