
using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;

namespace TravelDiary.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Home() { return View(); }
    }
}