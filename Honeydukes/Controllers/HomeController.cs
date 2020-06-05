using Microsoft.AspNetCore.Mvc;

namespace Honeydukes.Controllers
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