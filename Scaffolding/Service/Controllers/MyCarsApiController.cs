using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Service.Data;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCarsApiController : ControllerBase
    {
        private readonly ServiceContext _context;

        public MyCarsApiController(ServiceContext context)
        {
            _context = context;
        }

        // GET: api/MyCarsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MyCar>>> GetMyCar()
        {
            return await _context.MyCar.ToListAsync();
        }

        // GET: api/MyCarsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MyCar>> GetMyCar(int id)
        {
            var myCar = await _context.MyCar.FindAsync(id);

            if (myCar == null)
            {
                return NotFound();
            }

            return myCar;
        }

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
            _context.MyCar.Add(myCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMyCar", new { id = myCar.Id }, myCar);
        }

        // DELETE: api/MyCarsApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyCar(int id)
        {
            var myCar = await _context.MyCar.FindAsync(id);
            if (myCar == null)
            {
                return NotFound();
            }

            _context.MyCar.Remove(myCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MyCarExists(int id)
        {
            return _context.MyCar.Any(e => e.Id == id);
        }
    }
}
