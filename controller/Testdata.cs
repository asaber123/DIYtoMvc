using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;



namespace DIYtoMvc.Controllers;
public class Testdata : Controller{
    public IActionResult Index()
    {

        // //Read json file and parse
        // var JsonStr = System.IO.File.ReadAllText("comments.json");
        // //Making the json file into an instance of the class commments. 
        // var JsonObj = JsonConvert.DeserializeObject<IEnumerable<Commments>>(JsonStr);
        // //Sending it to the view
        // return View(JsonObj);
        return View();

    }
    //This only runns when there is a post request
    [HttpPost]
    public IActionResult Index(CommmentsModel model){
        if(ModelState.IsValid){
            //Lagrar data

        }
        else{

        }
        return View();
    }
}