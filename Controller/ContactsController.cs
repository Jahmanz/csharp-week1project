using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class ContactsController : Controller
    {

      [HttpGet("/contacts")]
      public ActionResult Index()
      {
          return View();
      }

      [HttpGet("/contacts/new")]
      public ActionResult CreateForm()
      {
          return View(newContact);
      }

      [HttpPost("/contacts")]
      public ActionResult Details()
      {
      string newName = (Request.Form["contact-name"]);
       string newPhone = (Request.Form["contact-phone"]);
       string newAddress = (Request.Form["contact-address"]);

       Contact newContact = new Contact(newName, newPhone, newAddress);

       return View("Details", newContact);
      }

    }
}
