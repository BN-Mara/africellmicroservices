using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp;

namespace SubscriberManagement
{
    public class Entreprise:Subscriber
    {
        [Required]
        [StringLength(SubscriberConsts.SubscriberNationalIdMaxLength)]
        public virtual string NationalId { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberCompanyNameMaxLength)]
        public virtual string EntrepriseName { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberResponsibleMaxLength)]
        public virtual string Responsible { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberLegalFormMaxLength)]
        public virtual string LegalForm { get; protected set; }
        protected Entreprise() { }
        public  Entreprise(Guid id, [NotNull] string phoneNumber, [NotNull] string nationalId, [NotNull] string entrepriseName, [NotNull] string responsible, [NotNull] string legalForm,
           [NotNull] string address, DateTime? activationDate = null, DateTime? expiryDate = null, string initialICCID = null)
       : base(id)
        {
            
            SetPhoneNumber(phoneNumber);
            SetNationalId(nationalId);
            SetEntrepriseName(entrepriseName);
            SetResponsible(responsible);
            SetLegalForm(legalForm);
            SetAddress(address);
            ActivationDate = activationDate;
            ExpiryDate = expiryDate;
            InitialICCID =initialICCID;
           
        }

        public Subscriber SetNationalId([NotNull] string nationalId)
        {
            if (this.Type != SubscriberType.ENTREPRISE)
            {
                throw new ArgumentException($"NationalId can be set only for corporates");
            }
            Check.NotNullOrWhiteSpace(nationalId, nameof(NationalId), SubscriberConsts.SubscriberNationalIdMaxLength);
            NationalId = nationalId;
            return this;
        }
        public Subscriber SetEntrepriseName([NotNull] string companyName)
        {
            if (this.Type != SubscriberType.ENTREPRISE)
            {
                throw new ArgumentException($"CompanyName can be set only for corporates");
            }
            Check.NotNullOrWhiteSpace(companyName, nameof(EntrepriseName), SubscriberConsts.SubscriberCompanyNameMaxLength);
            EntrepriseName = companyName;
            return this;
        }
        public Subscriber SetResponsible([NotNull] string responsible)
        {
            if (this.Type != SubscriberType.ENTREPRISE)
            {
                throw new ArgumentException($"Responsible can be set only for corporates");
            }
            Check.NotNullOrWhiteSpace(responsible, nameof(Responsible), SubscriberConsts.SubscriberResponsibleMaxLength);
            Responsible = responsible;
            return this;
        }
        public Subscriber SetLegalForm([NotNull] string legalForm)
        {
            if (this.Type != SubscriberType.ENTREPRISE)
            {
                throw new ArgumentException($"LegalForm can be set only for corporates");
            }
            Check.NotNullOrWhiteSpace(legalForm, nameof(LegalForm), SubscriberConsts.SubscriberLegalFormMaxLength);
            LegalForm = legalForm;
            return this;
        }

    }
}
