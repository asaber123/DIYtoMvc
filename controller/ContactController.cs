using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;


namespace DIYtoMvc.Controllers;
public class Contact : Controller{

    //Ändrar routen till about
    //[Route("/about")]
    public IActionResult Index()
    {
         

        return View();

    }
}