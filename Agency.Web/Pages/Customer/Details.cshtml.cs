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
    public class DetailsModel : PageModel
    {
        private readonly Agency.Web.Data.ApplicationDbContext _context;

        public DetailsModel(Agency.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Agency.Web.Models.Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
