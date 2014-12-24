using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Host.WebApi.Models;
using AutoMapper;

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
            var result = Mapper.Map<List<MessageModel>>(service.GetMessages().ToList());
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // GET api/messageboard/5
        public HttpResponseMessage Get(int id)
        {
            var result = Mapper.Map<MessageModel>(service.GetMessage(id));
            return Request.CreateResponse(HttpStatusCode.OK, result);
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
