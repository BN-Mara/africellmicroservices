using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace SubscriberManagement
{
    public class SubscriberNotExistingException : BusinessException
    {
        public SubscriberNotExistingException()
            : base("SB:000003", $"The  subscriber does not exists!")
        {

        }
    }
}
