using Microsoft.AspNetCore.Mvc;
using DebosVendors.Models;

namespace DebosVendors.Controllers
{
  public class HomeController : Controller  
  {

        [HttpGet("/")] 
      public ActionResult Index() 
      {
        return View();
      }
  }
}