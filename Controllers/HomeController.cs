using Microsoft.AspNetCore.Mvc;
using System;
using AdressBook.Models;
using System.Collections.Generic;

namespace AdressBook.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View(Contact.GetContacts());
      }
      [HttpGet("/contact/form")]
      public ActionResult CreateContact()
      {
        return View();
      }
      [HttpPost("/contact/new")]
      public ActionResult ContactConfirmation()
      {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-address"], Request.Form["contact-phone"]);
        return View(newContact);
      }
      [HttpGet("/contact/clear")]
      public ActionResult ClearContacts()
      {
        Contact.ClearContacts();
        return View();
      }
    }
}
