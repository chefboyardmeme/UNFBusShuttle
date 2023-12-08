using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UNFBusShuttle.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDriver()
        { return View(); }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }


        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
