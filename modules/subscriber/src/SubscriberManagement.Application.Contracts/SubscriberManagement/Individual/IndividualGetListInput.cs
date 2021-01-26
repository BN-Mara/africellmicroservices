using Africell.Erp.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SubscriberManagement
{
    public class IndividualGetListInput:SubscriberGetListInput
    {
        public Gender? Gender { get; set; }
        public IDType? IDType { get; set; }
        public string Nationality { get; set; }
    }
}
