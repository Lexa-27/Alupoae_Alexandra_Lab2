using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alupoae_Alexandra_Lab2.Data;
using Alupoae_Alexandra_Lab2.Models;

namespace Alupoae_Alexandra_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Alupoae_Alexandra_Lab2.Data.Alupoae_Alexandra_Lab2Context _context;

        public DetailsModel(Alupoae_Alexandra_Lab2.Data.Alupoae_Alexandra_Lab2Context context)
        {
            _context = context;
        }

        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var borrowing = await _context.Borrowing
                .Include(b => b.Member)
                .Include(b => b.Book)
                    .ThenInclude(b => b.Author)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}
