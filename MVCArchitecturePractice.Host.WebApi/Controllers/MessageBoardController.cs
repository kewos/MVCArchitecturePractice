using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Service.Contrast;
using MVCArchitecturePractice.Core.Entity;
using MVCArchitecturePractice.Host.WebApi.Models;
using MVCArchitecturePractice.Service.Dto;

namespace MVCArchitecturePractice.Host.WebApi.Controllers
{
    [RoutePrefix("api/MessageBoard")]
    public class MessageBoardController : ApiController
    {
        private IMessageBoardService messageBoardService;
        private IAuthenticationService authenticationService;

        public MessageBoardController(IServiceFactory serviceFactory)
        {
            this.messageBoardService = serviceFactory.GetService<IMessageBoardService>();
            this.authenticationService = serviceFactory.GetService<IAuthenticationService>();
        }

        [Route("Get_Messages")]
        [HttpGet]
        [Authorize]
        public HttpResponseMessage Get_Messages()
        {
            HttpResponseMessage result;
            try
            {
                var data = messageBoardService.GetMessages();
                result = Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                result = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);
            }

            return result;
        }

        [Route("Get_MessageById")]
        [HttpGet]
        public HttpResponseMessage Get_MessageById(int id)
        {
            HttpResponseMessage result;
            try
            {
                var data = messageBoardService.GetMessage(id);
                result = Request.CreateResponse(HttpStatusCode.ExpectationFailed, data);
            }
            catch (Exception e)
            {
                result = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);
            }

            return result;
        }

        [Route("Post_Message")]
        [HttpPost]
        public HttpResponseMessage Post_Message([FromBody]MessageDto messageDto)
        {
            HttpResponseMessage result;
            try
            {
                messageBoardService.InsertMessage(messageDto);
                result = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                result = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);
            }

            return result;
        }

        [Route("Put_Message")]
        [HttpPut]
        public HttpResponseMessage Put_Message([FromBody]MessageDto messageDto)
        {
            HttpResponseMessage result;
            try
            {
                messageBoardService.UpdateMessage(messageDto);
                result = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                result = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);
            }

            return result;
        }

        [Route("Delete_Message")]
        [HttpDelete]
        public HttpResponseMessage Delete_Message(int id)
        {
            HttpResponseMessage result;
            try
            {
                messageBoardService.DeleteMessage(id);
                result = Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                result = Request.CreateResponse(HttpStatusCode.ExpectationFailed, e.Message);
            }

            return result;
        }
    }
}
