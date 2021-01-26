using Africell.Erp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SubscriberManagement
{
    public class IndividualInput:SubscriberInput
    {
        [StringLength(SubscriberConsts.SubscriberNameMaxLength,MinimumLength =SubscriberConsts.SubscriberNameMinLength)]
        [Required]
        public  string Firstname { get;set; }
        [StringLength(SubscriberConsts.SubscriberNameMaxLength,MinimumLength =SubscriberConsts.SubscriberNameMinLength)]
        [Required]
        public  string LastName { get;set; }
        [StringLength(SubscriberConsts.SubscriberNameMaxLength,MinimumLength =SubscriberConsts.SubscriberNameMinLength)]
        public  string MiddleName { get;set; }
        [DataType(DataType.Date)]
        public  DateTime BirthDate { get;  set; }
        public  string PersonImage { get;  set; }
        [Required]
        public  Gender Gender { get;set; }
        [Required]
        public  IDType IDType { get; set; }
        [StringLength(SubscriberConsts.SubscriberIDRefMaxLength)]
        [Required]
        public  string IDRef { get;  set; }
        public  string IDImage { get; set; }
        [DataType(DataType.Date)]
        public  DateTime? IDDeliveryDate { get;set; }
        [DataType(DataType.Date)]
        public  DateTime? IDExpireDate { get;set; }
        [StringLength(SubscriberConsts.SubscriberNationalityMaxLength)]
        [Required]
        public  string Nationality { get; set; }

    }
}
