
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Eterna.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id=1,
                    Desc="gbvbldfznvSDKNvkslncs",
                    Title1="Selam",
                    Title2="BP200",
                    BtnText="jcdnkjdsc",


                    

                },
            };
            return View();
        }

        public IActionResult About()
        {

            return View();
        }
    }
}
