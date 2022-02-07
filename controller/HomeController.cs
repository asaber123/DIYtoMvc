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
        //Variable to get the date when user enters the page
        var date = DateTime.Now;
        //Making it into a string variable
        string dateString = date.ToString("H:mm:ss");
        //Setting the string to session variable
        HttpContext.Session.SetString("sessionDate", dateString);
        //Getting the session variabnle that was created and store it to a variable
        string session = HttpContext.Session.GetString("sessionDate");
        //Putting the variable into a viewbag, 
        ViewBag.session = session;
        return View();

    }
}