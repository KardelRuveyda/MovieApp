using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class MovieController:Controller
    {
     public IActionResult Index()
     {
         return View();
     }
    public IActionResult CreateAction()
     {
         return View();
     }
     
     
    public IActionResult List()
     {
         return View();
     }

     
    public IActionResult Details()
     {
         return View();
     }
     
     
    }
}