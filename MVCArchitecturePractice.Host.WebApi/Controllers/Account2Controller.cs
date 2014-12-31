//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web;
//using System.Web.Security;
//using MVCArchitecturePractice.Core.Contrast;
//using MVCArchitecturePractice.Service.Contrast;
//using MVCArchitecturePractice.Core.Entity;
//using MVCArchitecturePractice.Service.Dto;
//using System.Web.UI;

//namespace MVCArchitecturePractice.Host.WebApi.Controllers
//{
//    [RoutePrefix("api/Account")]
//    public class AccountController : ApiController
//    {
//        IAuthenticationService authenticationService;

//        public AccountController(IAuthenticationService authenticationService)
//        {
//            this.authenticationService = authenticationService;
//        }

//        [Route("Login")]
//        [HttpPost]
//        public HttpResponseMessage Login([FromBody]UserDto userDto)
//        {
//            var isvalid = authenticationService.UserIsValid(userDto);
//            return Request.CreateResponse(HttpStatusCode.ExpectationFailed); ;
//        }

//        protected string CryptographyPassword(string password)
//        {
//            return FormsAuthentication.HashPasswordForStoringInConfigFile(password, "sha1");
//        }

//        private void LoginProcess(UserDto userDto, bool isRemeber)
//        {
//            var now = DateTime.Now;
//            string roles = "Admin";

//            var ticket = new FormsAuthenticationTicket(
//                version: 1,
//                name: userDto.ID.ToString(),
//                issueDate: now,
//                expiration: now.AddMinutes(30),
//                isPersistent: isRemeber,
//                userData: roles,
//                cookiePath: FormsAuthentication.FormsCookiePath);

//            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
//            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
//        }
//    }
//}