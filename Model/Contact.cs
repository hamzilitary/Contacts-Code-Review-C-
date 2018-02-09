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
        
  }
}
