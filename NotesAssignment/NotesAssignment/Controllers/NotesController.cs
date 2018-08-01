using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotesAssignment.Models;

namespace NotesAssignment.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : Controller
    {
        public IList<Notes> NotesAvailable = new List<Notes>(new[]
        {
            new Notes(){Title="title1", PlainText="plaintext1",Labels= new List<String>() {"Label1","Label2"},CheckList=new List<String>(){"CheckList1","CheckList2" },PinStatus=true},
            new Notes(){Title="title2", PlainText="plaintext2",Labels= new List<String>() {"Label2","Label2"},CheckList=new List<String>(){"CheckList2","CheckList2" },PinStatus=true},
            new Notes(){Title="title3", PlainText="plaintext3",Labels= new List<String>() {"Label3","Label2"},CheckList=new List<String>(){"CheckList3","CheckList2" },PinStatus=true},
            new Notes(){Title="title4", PlainText="plaintext4",Labels= new List<String>() {"Label4","Label2"},CheckList=new List<String>(){"CheckList4","CheckList2" },PinStatus=true},
            new Notes(){Title="title5", PlainText="plaintext5",Labels= new List<String>() {"Label5","Label2"},CheckList=new List<String>(){"CheckList5","CheckList2" },PinStatus=true},

        });
        public IList<Notes> Index()
        {
            //ViewBag.Data = NotesAvailable;
            //return View();
            return NotesAvailable;
        }
    }
}