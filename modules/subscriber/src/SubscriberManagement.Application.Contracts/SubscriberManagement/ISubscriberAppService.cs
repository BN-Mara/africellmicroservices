using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberManagement
{
    public interface ISubscriberAppService
    {
        Task<SubscriberDto> Check(Guid Id, bool valid);
    }
}
