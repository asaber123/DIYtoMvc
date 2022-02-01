using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;



namespace DIYtoMvc.Controllers;
public class Testdata : Controller{
    public IActionResult Index()
    {
        //Read json file
        var JsonStr = System.IO.File.ReadAllText("comments.json");
        //Convert the json file to a list
        var JsonObj = JsonConvert.DeserializeObject<List<CommmentsModel>>(JsonStr);
        //Return it to the view
        return View(JsonObj);

    }
    //This only runns when there is a post request
    [HttpPost]
    public IActionResult Index(CommmentsModel model){
        if(ModelState.IsValid){
        //Store data to json file
        //Read json file and parse
        var JsonStr = System.IO.File.ReadAllText("comments.json");
        //Making the json file into an instance of the class commments. 
        var JsonObj = JsonConvert.DeserializeObject<List<CommmentsModel>>(JsonStr);

        if(JsonObj != null)
        {
            JsonObj.Add(model);
        }
        System.IO.File.WriteAllText("comments.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));
        ModelState.Clear();
        }

        return View();
    }
}