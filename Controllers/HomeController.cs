using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using easycontacts.Models;
using LiteDB;


namespace easycontacts.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            using (var db = new LiteDatabase(@"contact.db"))
            {
                var contacts = db.GetCollection<ContactList>("contacts");

                return View(contacts);
            }
        }

        public IActionResult Add()
        {
            using (var db = new LiteDatabase(@"contact.db"))
            {
                var contacts = db.GetCollection<ContactList>("contacts");
                var newContact = new Contact();
                newContact.Id = new Guid();
                newContact.Name = "Paulo";
                contacts.Insert(con)

                return View(contacts);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
