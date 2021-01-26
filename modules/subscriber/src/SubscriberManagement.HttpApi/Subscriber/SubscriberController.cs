using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Json;

namespace SubscriberManagement
{
    [RemoteService]
    [Area("subscriberManagement")]
    [Route("api/subscriberManagement")]
    public class SubscriberController:SubscriberManagementController
    {

        private readonly IJsonSerializer _jsonSerializer;
        public SubscriberController(IJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }
        [HttpGet]
        public  ActionResult Index()
        {
            var newLine = Environment.NewLine + Environment.NewLine;

            return Content(
                "Subscriber API \n"+
                "Claims: " + User.Claims.Select(c => $"{c.Type} = {c.Value}").JoinAsString(" | ") + newLine +
                "CurrentUser: " + _jsonSerializer.Serialize(CurrentUser) + newLine
            );
        }

        [HttpGet]
        [Route("CheckNumber")]
        public ActionResult Index([FromQuery(Name = "phoneNumber")] string phoneNumber)
        {
            return Ok(new {isRegistered=false, phoneNumber=phoneNumber, dateRegistered=DateTime.Now});
        }
    }
}
