using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var movie = new Movie
        {
            Title = "Hi",
            ReleaseDate = DateTime.Now,
            Category = null,
            Evaluation = 10,
            Price = 20000
        };

        return RedirectToAction("Privacy", movie);
        //return View();
    }

    public IActionResult Privacy(Movie movie)
    {
        if (ModelState.IsValid)
        {

        }

        foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
        {
            Console.WriteLine(error.ErrorMessage);
        }

        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}