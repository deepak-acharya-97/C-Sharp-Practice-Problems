using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class TicketController : Controller
    {
        [HttpGet("/tckt")]
        public IActionResult Index()
        {
            //get some stuff from db
            var s = new Seat() { Location = "PVR Koramangala", Price = 499.50 };
            return View(s);// Content("Hello From Ticket");
        }
        public string Hello() => "Hello From Ticket";
        //[HttpGet("/hll")]
        //public string Hello() => "Not The Default One";
    }
}