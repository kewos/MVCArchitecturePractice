using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCArchitecturePractice.Data;
using MVCArchitecturePractice.Core.Data;

namespace MVCArchitecturePractice.Web.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWorker unitOfWork = new UnitOfWorker();
        private Repository<Message> messageRepository;

        public HomeController()
        {
            messageRepository = unitOfWork.Repository<Message>();
        }

        public ActionResult Index()
        {
            IEnumerable<Message> messages =  messageRepository.Table.ToList();
            return View(messages);
        }

        public ActionResult SendMessage()
        {
            var model = new Message();
            model.ModifiedDate = System.DateTime.Now;
            model.AddedDate = System.DateTime.Now;
            model.UserId = 1;
            model.Comment = "test";
            messageRepository.Insert(model);
            return RedirectToAction("Index");
        }

        public ActionResult DetailMessage(int id)
        {
            var model = messageRepository.GetById(id);
            return View(model);
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