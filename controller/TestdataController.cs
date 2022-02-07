using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DIYtoMvc.Models;
using Newtonsoft.Json;



namespace DIYtoMvc.Controllers;
public class Testdata : Controller{
    // [HttpGet("/Test")]
    public IActionResult Index()
    {
        //Read json file
        var JsonStr = System.IO.File.ReadAllText("comments.json");
        //Convert the json file to a list
        var JsonObj = JsonConvert.DeserializeObject<List<CommmentsModel>>(JsonStr);

        ViewBag.comments = JsonObj;
        ViewBag.count = JsonObj.Count();


        string session = HttpContext.Session.GetString("sessionDate");


        ViewBag.session = session;



        var date = DateTime.Now;
        string dateString = date.ToString("H:mm:ss");
        DateTime time2 = DateTime.Parse(dateString);    
        DateTime time1 = DateTime.Parse(ViewBag.session);
        TimeSpan ts = time2 - time1;
        ViewBag.amountOfTime = ts;



        
        return View();


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



        // Reading comments

        //Read json file
        var JsonStr2 = System.IO.File.ReadAllText("comments.json");
        //Convert the json file to a list
        var JsonObj2 = JsonConvert.DeserializeObject<List<CommmentsModel>>(JsonStr2);

        //ViewBag.count = JsonObj2.Count();
        ViewBag.comments = JsonObj2;

        

        string session = HttpContext.Session.GetString("sessionDate");
        ViewBag.session = session;



        var date = DateTime.Now;
        string dateString = date.ToString("H:mm:ss");
        DateTime time2 = DateTime.Parse(dateString);    
        DateTime time1 = DateTime.Parse(ViewBag.session);
        TimeSpan ts = time2 - time1;
        ViewBag.amountOfTime = ts;




        return View();
    }
}