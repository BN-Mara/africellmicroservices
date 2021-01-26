using System;
using System.Collections.Generic;
using System.Text;
namespace SubscriberManagement
{
    [Serializable]
    public class PhoneNumberRegisteredEto
    {
        public Guid Id { get;}
        public string PhoneNumber { get; set; }
        public PhoneNumberRegisteredEto() { }
        public PhoneNumberRegisteredEto(Guid id, string phoneNumber){
            Id = id;
            PhoneNumber = phoneNumber;
        }
    }
}
