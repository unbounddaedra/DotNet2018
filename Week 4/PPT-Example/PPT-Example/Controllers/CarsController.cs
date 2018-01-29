using PPT_Example.Models;
using PPT_Example.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPT_Example.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult CarsList()
        {
            var Factory = new CarFactory();

            var viewModel = new CarListViewModel(Factory.Cars);

            return View(viewModel);
        }
    }
}

