using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataLayer;
using Domain.Entities;

namespace MyCarCare.Pages.Transactions.Fuel
{
    public class CreateModel : PageModel
    {
        private readonly DataLayer.MyCarDBContext _context;

        public CreateModel(DataLayer.MyCarDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            this.cartrx = new MyCarTrx() { Id = 0, EnteredBy = "abel", TrxDate = System.DateTime.Now.ToString(), TrxMileage = "1200" };
            return Page();
        }

        [BindProperty]
        public MyCarFuel MyCarFuel { get; set; }

        [BindProperty] 
        public MyCarTrx cartrx { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MyCarFuels.Add(MyCarFuel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
