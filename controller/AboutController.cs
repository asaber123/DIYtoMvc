using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;


namespace DIYtoMvc.Controllers;
public class About : Controller{

    //Ändrar routen till about
    //[Route("/about")]
    public IActionResult Index()
    {
                 //List from viewData
        List<LeadersModel> leaders = new List<LeadersModel>
            {
                new LeadersModel {Name = "Åsa Berglund", Email = "asaberglund@diy.no", PhoneNumber = "0808627365" },
                new LeadersModel {Name = "Per Johnsson", Email = "perjohnsson@diy.no", PhoneNumber = "0808627365" },
                new LeadersModel {Name = "Ida Nilsson", Email = "idabnilsson@diy.no", PhoneNumber = "0808629365" }

            };
        ViewData["LeadersList"] = leaders;
        


        return View();

    }
}