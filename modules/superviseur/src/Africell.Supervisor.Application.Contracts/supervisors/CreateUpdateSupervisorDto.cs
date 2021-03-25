using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Africell.Supervisor.supervisors
{
    public class CreateUpdateSupervisorDto
    {
        public byte[] Photo { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string SecteurActivite { get; set; }
    }
}
