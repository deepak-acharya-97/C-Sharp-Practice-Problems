﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }
        public IList<Customer> Customers { get; private set; }
        [TempData]
        public string Message { get; set; }
        public async Task OnGetAsync()
        {
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteMadiAsync(int id)
        {
            var customers = await _db.Customers.FindAsync(id);
            if(customers != null)
            {
                _db.Customers.Remove(customers);
                await _db.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}
