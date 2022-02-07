using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;


namespace DIYtoMvc.Controllers;
public class Comments : Controller{

    //Ändrar routen till about
    //[Route("/about")]
    public IActionResult Index()
    {
        

        //Read json file
        var JsonStr = System.IO.File.ReadAllText("comments.json");
        //Convert the json file to a list
        var JsonObj = JsonConvert.DeserializeObject<List<CommmentsModel>>(JsonStr);
        //Return it to the view
        return View(JsonObj);

    }
}