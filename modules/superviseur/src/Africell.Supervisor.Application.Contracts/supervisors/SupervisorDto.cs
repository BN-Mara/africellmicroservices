using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Africell.Supervisor.supervisors
{
    public class SupervisorDto : AuditedEntityDto<Guid>
    {
        public byte[] Photo { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}
