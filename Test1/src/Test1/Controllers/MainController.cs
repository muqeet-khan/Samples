using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Test1.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1.Controllers
{
    /// <summary>
    /// This is the main controller class.
    /// </summary>
    public class MainController : Controller
    {
        private RequestDetailsService _details;
        private ServerDetailsService _serverDetails;

        public MainController(RequestDetailsService details,ServerDetailsService serverDetails)
        {
            _details = details;
            _serverDetails = serverDetails;
        }

        // GET: /<controller>/
        /// <summary>
        /// This is the main action method.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            //this is singleton
            _serverDetails.AddDetail("WS4: " + DateTime.Now.ToString());
            //this is scoped
            _details.AddDetail("Home: " + DateTime.Now.ToString());
            ViewData["ControllerName"] = "Home";
            return View();
        }
    }
}
