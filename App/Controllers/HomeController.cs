using Microsoft.AspNetCore.Mvc;
using System;
using Application.Models;

namespace Application.Controllers
{
    public class HomeController : Controller
    {

        public string wordCount;

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(wordCount);
        }

        [HttpPost("/")]
        public ActionResult CheckWords()
        {
            return View();
        }
    }
}
