using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SubscriberManagement
{
    public class SubscriberGetListInput:PagedAndSortedResultRequestDto
    {
        public Guid? CreatedBy { get; set; }
        public bool? IsVerified { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public bool? IsValidated { get; set; }
        public Guid? Validator { get; set; }
    }
}
