using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleInjectorInit.Interfaces;

namespace SimpleInjectorInit.Controllers
{
    public class UserController : Controller
    {
        private readonly IBasicRepository _repository;

        //
        // Use constructor injection for the dependancies
        public UserController(IBasicRepository rep)
        {
            _repository = rep;
        }

        //
        // Implement UserController methods here.

        //
        // GET: /User/

        public ActionResult Index()
        {
            ViewBag.RepoMessage = _repository.GetHelloWorld();

            return View();
        }
        
        public string Heatbeat()
        {
            return "I'm Alive";
        }

    }
}
