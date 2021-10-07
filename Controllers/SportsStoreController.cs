using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSportsStore.Controllers
{
    public class SportsStoreController : Controller
    {
        //Get: /SportsStore/
        public IActionResult Index()
        {
            //return "This is the default page";
            return View();
        }



        //Get: /SportsStore/Shoes../
        //public string Welcome()
        //{
        //    return "This is the shoe category page action method...";
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
