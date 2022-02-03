using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;


namespace DIYtoMvc.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        var date = DateTime.Now;
        string dateString = date.ToString("yyyy-MM-dd");
        HttpContext.Session.SetString("sessionDate", "Todays date is " + dateString);
        string session = HttpContext.Session.GetString("sessionDate");
        ViewBag.session = session;
        return View();

    }
}