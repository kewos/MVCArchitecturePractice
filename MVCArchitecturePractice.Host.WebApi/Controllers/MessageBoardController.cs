using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Host.WebApi.Models;

namespace MVCArchitecturePractice.Host.WebApi.Controllers
{
    public class MessageBoardController : ApiController
    {
        private IMessageBoardService service;

        public MessageBoardController(IMessageBoardService service)
        {
            this.service = service;
        }


        // GET api/messageboard
        public HttpResponseMessage Get()
        {
            var result = service.GetMessages().Select(n =>
                new MessageModel
                {
                    ID = n.ID,
                    UserId = n.UserId,
                    Comment = n.Comment,
                    AddDate = n.AddDate,
                    ModifyDate = n.ModifyDate,
                });
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // GET api/messageboard/5
        public HttpResponseMessage Get(int id)
        {
            var result = service.GetMessage(id);
            var obj = new MessageModel
                {
                    ID = result.ID,
                    UserId = result.UserId,
                    Comment = result.Comment,
                    AddDate = result.AddDate,
                    ModifyDate = result.ModifyDate,
                };
            return Request.CreateResponse(HttpStatusCode.OK, obj);
        }

        // POST api/messageboard
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse(HttpStatusCode.OK, value);
        }

        // PUT api/messageboard/5
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // DELETE api/messageboard/5
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
