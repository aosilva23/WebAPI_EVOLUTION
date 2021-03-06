using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_EVOLUTION.Data;
using WebAPI_EVOLUTION.Models;

namespace WebAPI_EVOLUTION.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly WebAPI_EVOLUTIONContext _context;

        public BookingsController(WebAPI_EVOLUTIONContext context)
        {
            _context = context;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bookings>>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bookings>> GetBookings(int id)
        {
            var bookings = await _context.Bookings.FindAsync(id);

            if (bookings == null)
            {
                return NotFound();
            }

            return bookings;
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookings(int id, Bookings bookings)
        {
            if (id != bookings.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingsExists(id))
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

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bookings>> PostBookings(Bookings bookings)
        {
            _context.Bookings.Add(bookings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookings", new { id = bookings.Id }, bookings);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookings(int id)
        {
            var bookings = await _context.Bookings.FindAsync(id);
            if (bookings == null)
            {
                return NotFound();
            }

            _context.Bookings.Remove(bookings);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingsExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
