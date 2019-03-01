using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExamenTest.DataAccess;
using ExamenTest.Models;

namespace ExamenTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ExamenTest.DataAccess.EntityFrameworkBD _context;

        public IndexModel(ExamenTest.DataAccess.EntityFrameworkBD context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
