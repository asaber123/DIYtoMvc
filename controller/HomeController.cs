using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;


namespace DIYtoMvc.Controllers;
public class Home : Controller
{
    public IActionResult Index()
    {
        var date = DateTime.Now;
        string dateString = date.ToString("H:mm:ss");
        HttpContext.Session.SetString("sessionDate", dateString);

        string session = HttpContext.Session.GetString("sessionDate");
        ViewBag.session = session;
        return View();

    }
}