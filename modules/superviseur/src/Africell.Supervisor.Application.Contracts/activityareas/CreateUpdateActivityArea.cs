using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Africell.Supervisor.activityareas
{
    public class CreateUpdateActivityArea
    {
        [Required]
        public Guid SupervisorId { get; set; }
        [Required]
        public Guid PlaceId { get; set; }
    }
}
