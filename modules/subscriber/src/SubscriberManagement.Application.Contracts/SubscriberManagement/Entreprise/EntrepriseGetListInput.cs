using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SubscriberManagement
{
    public class EntrepriseGetListInput:SubscriberGetListInput
    {
       
        public string LegalForm { get; set; }
    }
}
