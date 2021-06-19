using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Domain.Entities;
using Domain.BLLInterfaces;
using DataLayer;



namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCarsApiController : ControllerBase
    {
        private readonly IVehicleBLL vehicle;

        public MyCarsApiController(IVehicleBLL _vehicle)
        {
            vehicle = _vehicle;
        }

        // GET: api/MyCarsApi
        [HttpGet]
        public IEnumerable<MyCar> GetMyCar()
        {
            return vehicle.getMyCarList();
        }


        
        // GET: api/MyCarsApi/5
        [HttpGet("{id}")]
        public MyCar GetMyCar(int id)
        {
            /*
            var myCar = await vehicle.get.MyCars.FindAsync(id);

            if (myCar == null)
            {
                return NotFound();
            }
            */

            return vehicle.getMyCar(id);

        }

        /*
        // PUT: api/MyCarsApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMyCar(int id, MyCar myCar)
        {
            if (id != myCar.Id)
            {
                return BadRequest();
            }

            _context.Entry(myCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MyCarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MyCarsApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MyCar>> PostMyCar(MyCar myCar)
        {
            _context.MyCars.Add(myCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyCar", new { id = myCar.Id }, myCar);
        }

        // DELETE: api/MyCarsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyCar(int id)
        {
            var myCar = await _context.MyCars.FindAsync(id);
            if (myCar == null)
            {
                return NotFound();
            }

            _context.MyCars.Remove(myCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MyCarExists(int id)
        {
            return _context.MyCars.Any(e => e.Id == id);
        }

        */


    }
}
