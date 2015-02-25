using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using MVCArchitecturePractice.Common.DTO;
using MVCArchitecturePractice.Core.Contrast;
using MVCArchitecturePractice.Core.Entity;
using MVCArchitecturePractice.Business.Contrast;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using MVCArchitecturePractice.Host.WebApi.Models;
using MVCArchitecturePractice.Host.WebApi.Providers;
using MVCArchitecturePractice.Host.WebApi.Results;
namespace MVCArchitecturePractice.Host.WebApi.Controllers
{
    [RoutePrefix("api/MessageBoard")]
    public class MessageBoardController : ApiController
    {
        private IMessageBoardBusiness messageBoardBusiness;
        private IAuthenticationBusiness authenticationBusiness;

        public MessageBoardController(IBusinessFactory BusinessFactory)
        {
            this.messageBoardBusiness = BusinessFactory.GetBusiness<IMessageBoardBusiness>();
        }

        [Route("Get_Messages")]
        [HttpGet]
        public HttpResponseMessage Get_Messages()
        {
            HttpResponseMessage result;
            try
            {
                var data = messageBoardBusiness.GetMessages();
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
                var data = messageBoardBusiness.GetMessage(id);
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
        public HttpResponseMessage Post_Message([FromBody]MessageDTO messageDto)
        {
            HttpResponseMessage result;
            try
            {
                messageBoardBusiness.InsertMessage(messageDto);
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
        public HttpResponseMessage Put_Message([FromBody]MessageDTO messageDTO)
        {
            HttpResponseMessage result;
            try
            {
                messageBoardBusiness.UpdateMessage(messageDTO);
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
                messageBoardBusiness.DeleteMessage(id);
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
