using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VarunNaggagaHTMLHelpers.Pages
{
    public class NaggagaModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Hi";
        }
        public void Hi()
        {
            ViewData["Message"] = "Namaste Naggaga";
        }
    }
}