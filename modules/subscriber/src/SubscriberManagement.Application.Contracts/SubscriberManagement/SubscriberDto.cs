using Africell.Erp.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SubscriberManagement
{
     public class SubscriberDto:FullAuditedEntityDto<Guid>
     {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string InitialICCID { get; set; }
        public string CurrentICCID { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public bool IsValidated { get; set; }
        public Guid? Validator { get; set; }
        public string Name { get; set; }

        public string NationalId { get; set; }
        public string EntrepriseName { get; set; }
        public string Responsible { get; set; }
        public string LegalForm { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PersonImage { get; set; }
        public Gender? Gender { get; set; }
        public IDType? IDType { get; set; }
        public string IDRef { get; set; }
        public string IDImage { get; set; }
        public DateTime? IDDeliveryDate { get; set; }
        public DateTime? IDExpireDate { get; set; }
        public string Nationality { get; set; }
    }
}
