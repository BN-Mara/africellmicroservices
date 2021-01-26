using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace SubscriberManagement
{
    public class PhoneNumberNotExistingException : BusinessException
    {
        public PhoneNumberNotExistingException(string phoneNumber)
            : base("SB:000002", $"The phonenumber {phoneNumber} does not exist!")
        {

        }
    }
}
