using Microsoft.AspNetCore.Mvc;
using TreatShop.Models;
using System.Linq;


namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatShopContext _db;
    public HomeController(TreatShopContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
  }
}