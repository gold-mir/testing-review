using Microsoft.AspNetCore.Mvc;
using System;
using Application.Models;
using System.Collections.Generic;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        public static Dictionary<string, string> wordCount;

        [HttpGet("/")]
        public ActionResult Index()
        {
            Console.WriteLine($"wordCount = {wordCount}");
            return View(wordCount);
        }

        [HttpPost("/")]
        public ActionResult CheckWords()
        {
            string word = Request.Form["word-input"];
            string sentence = Request.Form["sentence-input"];
            int count = RepeatCounter.GetWordCount(sentence, word);

            if(word == "" || sentence == "" || count == -1)
            {
                return View("Error");
            }

            wordCount = new Dictionary<string, string>(){
                {"word", word}, {"sentence", sentence}, {"count", $"{count}"}
            };


            return View("Index", wordCount);
        }
    }
}
