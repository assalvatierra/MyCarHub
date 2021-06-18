using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Service.Data;

namespace Service.Controllers
{
    public class MyCarsController : Controller
    {
        private readonly ServiceContext _context;

        public MyCarsController(ServiceContext context)
        {
            _context = context;
        }

        // GET: MyCars
        public async Task<IActionResult> Index()
        {
            var serviceContext = _context.MyCar.Include(m => m.MyAccount).Include(m => m.MyCarDrivetrain).Include(m => m.MyCarFuel).Include(m => m.MyCarModel).Include(m => m.MyCarTransmission);
            return View(await serviceContext.ToListAsync());
        }

        // GET: MyCars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myCar = await _context.MyCar
                .Include(m => m.MyAccount)
                .Include(m => m.MyCarDrivetrain)
                .Include(m => m.MyCarFuel)
                .Include(m => m.MyCarModel)
                .Include(m => m.MyCarTransmission)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myCar == null)
            {
                return NotFound();
            }

            return View(myCar);
        }

        // GET: MyCars/Create
        public IActionResult Create()
        {
            ViewData["MyAccountId"] = new SelectList(_context.Set<MyAccount>(), "Id", "Id");
            ViewData["MyCarDrivetrainId"] = new SelectList(_context.Set<MyCarDrivetrain>(), "Id", "Id");
            ViewData["MyCarFuelId"] = new SelectList(_context.Set<MyCarFuel>(), "Id", "Id");
            ViewData["MyCarModelId"] = new SelectList(_context.Set<MyCarModel>(), "Id", "Id");
            ViewData["MyCarTransmissionId"] = new SelectList(_context.Set<MyCarTransmission>(), "Id", "Id");
            return View();
        }

        // POST: MyCars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Year,Variant,MyCarModelId,MyCarFuelId,MyCarTransmissionId,MyCarDrivetrainId,PlateNo,Conduction,Vin,MyAccountId")] MyCar myCar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myCar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MyAccountId"] = new SelectList(_context.Set<MyAccount>(), "Id", "Id", myCar.MyAccountId);
            ViewData["MyCarDrivetrainId"] = new SelectList(_context.Set<MyCarDrivetrain>(), "Id", "Id", myCar.MyCarDrivetrainId);
            ViewData["MyCarFuelId"] = new SelectList(_context.Set<MyCarFuel>(), "Id", "Id", myCar.MyCarFuelId);
            ViewData["MyCarModelId"] = new SelectList(_context.Set<MyCarModel>(), "Id", "Id", myCar.MyCarModelId);
            ViewData["MyCarTransmissionId"] = new SelectList(_context.Set<MyCarTransmission>(), "Id", "Id", myCar.MyCarTransmissionId);
            return View(myCar);
        }

        // GET: MyCars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myCar = await _context.MyCar.FindAsync(id);
            if (myCar == null)
            {
                return NotFound();
            }
            ViewData["MyAccountId"] = new SelectList(_context.Set<MyAccount>(), "Id", "Id", myCar.MyAccountId);
            ViewData["MyCarDrivetrainId"] = new SelectList(_context.Set<MyCarDrivetrain>(), "Id", "Id", myCar.MyCarDrivetrainId);
            ViewData["MyCarFuelId"] = new SelectList(_context.Set<MyCarFuel>(), "Id", "Id", myCar.MyCarFuelId);
            ViewData["MyCarModelId"] = new SelectList(_context.Set<MyCarModel>(), "Id", "Id", myCar.MyCarModelId);
            ViewData["MyCarTransmissionId"] = new SelectList(_context.Set<MyCarTransmission>(), "Id", "Id", myCar.MyCarTransmissionId);
            return View(myCar);
        }

        // POST: MyCars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Year,Variant,MyCarModelId,MyCarFuelId,MyCarTransmissionId,MyCarDrivetrainId,PlateNo,Conduction,Vin,MyAccountId")] MyCar myCar)
        {
            if (id != myCar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myCar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyCarExists(myCar.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MyAccountId"] = new SelectList(_context.Set<MyAccount>(), "Id", "Id", myCar.MyAccountId);
            ViewData["MyCarDrivetrainId"] = new SelectList(_context.Set<MyCarDrivetrain>(), "Id", "Id", myCar.MyCarDrivetrainId);
            ViewData["MyCarFuelId"] = new SelectList(_context.Set<MyCarFuel>(), "Id", "Id", myCar.MyCarFuelId);
            ViewData["MyCarModelId"] = new SelectList(_context.Set<MyCarModel>(), "Id", "Id", myCar.MyCarModelId);
            ViewData["MyCarTransmissionId"] = new SelectList(_context.Set<MyCarTransmission>(), "Id", "Id", myCar.MyCarTransmissionId);
            return View(myCar);
        }

        // GET: MyCars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myCar = await _context.MyCar
                .Include(m => m.MyAccount)
                .Include(m => m.MyCarDrivetrain)
                .Include(m => m.MyCarFuel)
                .Include(m => m.MyCarModel)
                .Include(m => m.MyCarTransmission)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myCar == null)
            {
                return NotFound();
            }

            return View(myCar);
        }

        // POST: MyCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myCar = await _context.MyCar.FindAsync(id);
            _context.MyCar.Remove(myCar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyCarExists(int id)
        {
            return _context.MyCar.Any(e => e.Id == id);
        }
    }
}
