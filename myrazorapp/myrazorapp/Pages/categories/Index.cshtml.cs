using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myrazorapp.Data;
using myrazorapp.Models;

namespace myrazorapp.Pages.categories
{
    public class IndexModel : PageModel
    {
        private readonly myrazorapp.Data.EcomContext _context;

        public IndexModel(myrazorapp.Data.EcomContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
