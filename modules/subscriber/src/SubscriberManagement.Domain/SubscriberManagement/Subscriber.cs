using Africell.Erp.Shared;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace SubscriberManagement
{
    public abstract class Subscriber : FullAuditedAggregateRoot<Guid>
    {
        [NotNull]
        [StringLength(SubscriberConsts.SubscriberPhoneNumberMaxLength,
                      MinimumLength =SubscriberConsts.SubscriberPhoneNumberMinLength)]
        [Required]
        public virtual string PhoneNumber { get; protected set; }
        [NotNull]
        [StringLength(SubscriberConsts.SubscriberAddressMaxLength)]
        [Required]
        public virtual string Address { get;set; }
        public virtual string InitialICCID { get; set; }
        public virtual string CurrentICCID { get; protected set; }
        public virtual DateTime? ActivationDate { get; set; }
        public virtual DateTime? ExpiryDate { get; set; }
        [Required]
        public virtual bool IsVerified { get; set; } = false;
        public virtual DateTime? VerifiedDate { get; set; }
        public virtual bool? IsValidated { get; set; }
        public virtual Guid? Validator { get; set; }
        [NotNull]
        [Required]
        public virtual SubscriberType Type { get; protected set; }
        protected Subscriber() { }
        public Subscriber(Guid Id) : base(Id) { }

        
       
        public Subscriber SetAddress([NotNull] string address)
        {
            Check.NotNullOrWhiteSpace(address, nameof(Address), SubscriberConsts.SubscriberAddressMaxLength);
            Address = address;
            return this;
        }
       
       
        public Subscriber SetPhoneNumber([NotNull] string phoneNumber)
        {
            Check.NotNullOrWhiteSpace(phoneNumber, nameof(PhoneNumber), SubscriberConsts.SubscriberPhoneNumberMaxLength,
               SubscriberConsts.SubscriberPhoneNumberMinLength);
           
            AddDistributedEvent(new PhoneNumberRegisteredEto(this.Id,phoneNumber));
            PhoneNumber = phoneNumber;
            return this;
        }

    }
}
