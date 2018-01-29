using PPT_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPT_Example.Views.Home
{
    public class CarListViewModel
    {
        public IEnumerable<SelectListItem> CarsList { get; set; }

        public Car FastestCar { get; set; }


        public CarListViewModel(IEnumerable<Car> cars)
        {
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });


            FastestCar = cars.OrderByDescending(c => c.MaxSpeed).FirstOrDefault();     

        }
    }
}