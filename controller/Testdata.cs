using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;


namespace DIYtoMvc.Controllers;
public class Testdata : Controller{
    public IActionResult Index()
    {
        return View();

    }
}