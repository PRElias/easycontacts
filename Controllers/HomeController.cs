using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using easycontacts.Models;
using easycontacts.Repositories;

namespace easycontacts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] ContactRepository db)
        {
            return View(db.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(Contact contact, [FromServices] ContactRepository db)
        {
            db.Upsert(contact);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Edit(int id, [FromServices] ContactRepository db)
        {
            Contact contact = db.FindOne(id);
            return View(contact);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(Contact contact, [FromServices] ContactRepository db)
        {
            db.Upsert(contact);
            return RedirectToAction("Index");
        }
    }
}
