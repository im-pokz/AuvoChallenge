using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuvoChallenge.Models;

namespace AuvoChallenge.Controllers
{
    public class TransfersController : Controller
    {
        public IActionResult Index()
        {
            List<Transfer> list = new List<Transfer>();
            list.Add(new Transfer { Id = 1, Name = "Pietro", Value = 2000.0, Date = DateTime.Now });
            list.Add(new Transfer { Id = 2, Name = "Stone", Value = 4000.0, Date = DateTime.Now });
            return View(list);
        }
    }
}
