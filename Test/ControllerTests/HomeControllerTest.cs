using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Application.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView()
        {
            HomeController home = new HomeController();

            IActionResult indexView = home.Index();
            ViewResult result = indexView as ViewResult;

            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_ModelIsString()
        {
            HomeController home = new HomeController();

            var model = (home.Index() as ViewResult).ViewData.Model;

            Assert.IsInstanceOfType(model, typeof(string));
        }
    }
}
