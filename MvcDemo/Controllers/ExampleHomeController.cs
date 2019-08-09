using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    //[Route("")]
    //[Route("management-clients")]
    //public class ExampleHomeController : Controller
    //{
    //    [Route("")]
    //    [Route("initial-page")]
    //    //[Route("initial-page/{id}")]
    //    //[Route("initial-page/{id}/{category}")]
    //    //[Route("initial-page/{id}/{category?}")]
    //    [Route("initial-page/{id:int}/{category:guid}")]
    //    public IActionResult Index(int id, Guid category)
    //    {
    //        return View();
    //    }

    //    [Route("privacy")]
    //    [Route("privacy-politic")]
    //    public IActionResult Privacy()
    //    {
    //        return Json("{'name': 'Henrique'}");

    //        //var fileBytes = System.IO.File.ReadAllBytes(@"K:\file.txt");
    //        //var fileName = "hello.txt";
    //        //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

    //         // return Content("Anything");
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    [Route("error-found")]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }
    //}
}
