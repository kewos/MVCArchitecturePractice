using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCArchitecturePractice.Core.Entities;
using MVCArchitecturePractice.Service;

namespace MVCArchitecturePractice.Web.Controllers
{
    public class HomeController : Controller
    {
        private IMessageBoardService messageBoard;

        public HomeController(IMessageBoardService messageBoard)
        {
            this.messageBoard = messageBoard;
        }

        public ActionResult Index()
        {
            return View(messageBoard.GetMessages());
        }

        public ActionResult SendMessage()
        {
            var model = new Message();
            model.ModifiedDate = System.DateTime.Now;
            model.AddedDate = System.DateTime.Now;
            model.UserId = 1;
            model.Comment = "test";
            messageBoard.InsertMessage(model);
            return RedirectToAction("Index");
        }

        public ActionResult DetailMessage(int id)
        {
            return View(messageBoard.GetMessage(id));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}