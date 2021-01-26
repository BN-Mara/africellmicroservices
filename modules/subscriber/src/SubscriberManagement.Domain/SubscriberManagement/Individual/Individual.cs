using Africell.Erp.Shared;
using JetBrains.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp;

namespace SubscriberManagement
{
    public class Individual : Subscriber
    {
        [Required]
        [StringLength(SubscriberConsts.SubscriberNameMaxLength,
             MinimumLength = SubscriberConsts.SubscriberNameMinLength)]
        public virtual string Firstname { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberNameMaxLength,
             MinimumLength = SubscriberConsts.SubscriberNameMinLength)]
        public virtual string Lastname { get; protected set; }
        [StringLength(SubscriberConsts.SubscriberNameMaxLength,
             MinimumLength = SubscriberConsts.SubscriberNameMinLength)]
        public virtual string Middlename { get; protected set; }
        [DataType(DataType.Date)]
        [Required]
        public virtual DateTime BirthDate { get; protected set; }
        public virtual string PersonImage { get; protected set; }
        [Required]
        public virtual Gender Gender { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberIDTypeMaxLength)]
        public virtual IDType IDType { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberIDRefMaxLength)]
        public virtual string IDRef { get; protected set; }
        public virtual string IDImage { get; protected set; }
        [DataType(DataType.Date)]
        public virtual DateTime? IDDeliveryDate { get; protected set; }
        [DataType(DataType.Date)]
        public virtual DateTime? IDExpireDate { get; protected set; }
        [Required]
        [StringLength(SubscriberConsts.SubscriberNationalityMaxLength)]
        public virtual string Nationality { get; protected set; }
        protected Individual(){}
        public Individual(Guid id) : base(id)
        {
          
        }
        public Individual(Guid id, [NotNull] string phoneNumber, [NotNull] string firstName, [NotNull] string lastName, [NotNull] DateTime birthDate, [NotNull] string address,
                            [NotNull] Gender gender, [NotNull] string nationality, [NotNull] IDType idType, [NotNull] string idRef, string idImage = null, DateTime? idDeliveryDate = null,
                            DateTime? idExpireDate = null, string middleName = null, string personImage = null, string ICCID = null) : base(id)
        {
          
            SetPhoneNumber(phoneNumber);
            SetFirstname(firstName);
            SetLastName(lastName);
            SetMiddleName(middleName);
            SetBirthDate(birthDate);
            SetAddress(address);
            SetGender(gender);
            SetNationality(nationality);
            SetIDType(idType);
            SetIDRef(idRef);
            SetIDDeliveryDate(idDeliveryDate);
            SetIDExpireDate(idExpireDate);
            SetIDImage(idImage);
            SetPersonImage(personImage);
            InitialICCID = ICCID;
            


        }

        public Subscriber SetFirstname([NotNull] string firstName)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"Fistname can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(firstName, nameof(Firstname), SubscriberConsts.SubscriberNameMaxLength,
                SubscriberConsts.SubscriberNameMinLength);
            Firstname = firstName;
            return this;
        }
        public Subscriber SetLastName([NotNull] string lastName)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"LastName can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(lastName, nameof(Lastname), SubscriberConsts.SubscriberNameMaxLength,
                SubscriberConsts.SubscriberNameMinLength);
            Lastname = lastName;
            return this;
        }
        public Subscriber SetMiddleName([CanBeNull] string middlename)
        {
            if (middlename == null) return this;
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"MiddleName can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(middlename, nameof(Middlename), SubscriberConsts.SubscriberNameMaxLength,
                SubscriberConsts.SubscriberNameMinLength);
            Middlename = middlename;
            return this;
        }
        public Subscriber SetBirthDate([NotNull] DateTime birthDate)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"BirthDate can be set only for persons");
            }
            BirthDate = birthDate;
            return this;
        }
        public Subscriber SetIDType([NotNull] IDType idType)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"IDType can be set only for persons");
            }
            IDType = idType;
            return this;
        }
        public Subscriber SetIDRef([NotNull] string idRef)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"IDREf can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(idRef, nameof(IDRef), SubscriberConsts.SubscriberIDRefMaxLength);
            IDRef = idRef;
            return this;
        }
        public Subscriber SetIDImage([CanBeNull] string idImage)
        {
            if (idImage == null) return this;
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"IDImage can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(idImage, nameof(IDRef));
            IDImage = idImage;
            return this;
        }
        public Subscriber SetPersonImage([CanBeNull] string personImage)
        {
            if (personImage == null) return this;
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"PersonImage can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(personImage, nameof(PersonImage));
            PersonImage = personImage;
            return this;
        }
        public Subscriber SetGender([NotNull] Gender gender)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"Gender can be set only for persons");
            }
            Check.NotNull<Gender>(gender, nameof(Gender));
            Gender = gender;
            return this;
        }
        public Subscriber SetNationality([NotNull] string nationality)
        {
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"Nationality can be set only for persons");
            }
            Check.NotNullOrWhiteSpace(nationality, nameof(Nationality), SubscriberConsts.SubscriberNationalityMaxLength);
            Nationality = nationality;
            return this;
        }
        public Subscriber SetIDDeliveryDate([CanBeNull] DateTime? idDeliveryDate)
        {
            if (idDeliveryDate == null) return this;
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"IDDeliveryDate can be set only for persons");
            }
            IDDeliveryDate = idDeliveryDate;
            return this;
        }
        public Subscriber SetIDExpireDate([CanBeNull] DateTime? idDeliveryDate)
        {
            if (idDeliveryDate == null) return this;
            if (this.Type != SubscriberType.INDIVIDUAL)
            {
                throw new ArgumentException($"IDExpireDate can be set only for persons");
            }
            IDExpireDate = idDeliveryDate;
            return this;
        }
    }
}
