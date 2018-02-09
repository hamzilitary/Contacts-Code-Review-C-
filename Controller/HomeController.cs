using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Contacts.Models;

namespace Contacts.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
      public ActionResult Index()
      {
        List<Contact> allPeople = Contact.GetAll();
        return View (allPeople);
      }

    [HttpPost("/")]
      public ActionResult Create()
      {
        Contact newContact = new Contact(Request.Form["fullName"], Request.Form["address"], Convert.ToInt64(Request.Form["phone"]));
        newContact.ContactSave();
        List<Contact> allPeople = Contact.GetAll();
        return View ("index", allPeople);
      }


  }
}
