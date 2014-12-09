using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCArchitecturePractice.Service;
using MVCArchitecturePractice.Core;

namespace MVCArchitecturePractice.Api.Controllers
{
    public class MessageBoardController : ApiController
    {
        IMessageBoardService messageBoardService;

        public MessageBoardController() { }

        public MessageBoardController(IMessageBoardService messageBoardService)
        {
            this.messageBoardService = messageBoardService;
        }

        // GET api/values
        public IEnumerable<Message> Get()
        {
            return messageBoardService.GetMessages();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
