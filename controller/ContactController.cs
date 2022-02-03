using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;


namespace DIYtoMvc.Controllers;
public class Contact : Controller{

    //Ändrar routen till about
    //[Route("/about")]
    public IActionResult Index()
    {
        
        string? session2 = HttpContext.Session.GetString("test");
        ViewBag.sessionsvariabel= session2;
    ProductsModel product = new ProductsModel()
    {
        Title = "Toilet Paper",
        Price = 1.99
    };
    return View(product);

    }
}