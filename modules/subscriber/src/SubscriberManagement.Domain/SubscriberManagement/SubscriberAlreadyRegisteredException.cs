using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace SubscriberManagement
{
    public class SubscriberAlreadyRegisteredException : BusinessException
    {
        public SubscriberAlreadyRegisteredException(string phoneNumber)
            : base("SB:000001", $"A subscriber with phonenumber {phoneNumber} has already exists!")
        {

        }
    }
}
