using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agency.Web.Data;
using Agency.Web.Models;

namespace Agency.Web.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly Agency.Web.Data.ApplicationDbContext _context;

        public IndexModel(Agency.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Agency.Web.Models.Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
