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
            var result = Mapper.Map<List<MessageModel>>(service.GetMessages());
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // Read
        // GET api/messageboard/5
        public HttpResponseMessage Get(int id)
        {
            var result = Mapper.Map<MessageModel>(service.GetMessage(id));
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        //Create
        public HttpResponseMessage Post([FromBody]MessageModel model)
        {
            Message result = Mapper.Map<Message>(model);
            service.InsertMessage(result);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // Update
        // PUT api/messageboard/5
        public HttpResponseMessage Put([FromBody]MessageModel model)
        {
            Message result = Mapper.Map<Message>(model);
            service.UpdateMessage(result);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // Delete
        // DELETE api/messageboard/5
        public HttpResponseMessage Delete(int id)
        {
            service.DeleteMessage(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
