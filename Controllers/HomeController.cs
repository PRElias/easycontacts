using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using easycontacts.Models;
using easycontacts.Repositories;

namespace easycontacts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] IDatabase db)
        {
            return View(db.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact, [FromServices] IDatabase db)
        {
            db.Insert(contact);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(int id, [FromServices] IDatabase db)
        {
            Contact contact = db.FindOne(id);
            return View(contact);
        }
    }
}
