using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace CourseApi.Controllers
{
    [Produces("application/json")]
    [Route("api/KeuzevVaks")]
    public class KeuzevVaksController : Controller
    {
        private readonly SchoolContext _context;

        public KeuzevVaksController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/KeuzevVaks
        [HttpGet]
        public IEnumerable<KeuzevVak> GetKeuzevVak()
        {
            return _context.KeuzevVak;
        }

        // GET: api/KeuzevVaks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKeuzevVak([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var keuzevVak = await _context.KeuzevVak.SingleOrDefaultAsync(m => m.ID == id);

            if (keuzevVak == null)
            {
                return NotFound();
            }

            return Ok(keuzevVak);
        }

        // PUT: api/KeuzevVaks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKeuzevVak([FromRoute] int id, [FromBody] KeuzevVak keuzevVak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != keuzevVak.ID)
            {
                return BadRequest();
            }

            _context.Entry(keuzevVak).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KeuzevVakExists(id))
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

        // POST: api/KeuzevVaks
        [HttpPost]
        public async Task<IActionResult> PostKeuzevVak([FromBody] KeuzevVak keuzevVak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.KeuzevVak.Add(keuzevVak);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KeuzevVakExists(keuzevVak.ID))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKeuzevVak", new { id = keuzevVak.ID }, keuzevVak);
        }

        // DELETE: api/KeuzevVaks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKeuzevVak([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var keuzevVak = await _context.KeuzevVak.SingleOrDefaultAsync(m => m.ID == id);
            if (keuzevVak == null)
            {
                return NotFound();
            }

            _context.KeuzevVak.Remove(keuzevVak);
            await _context.SaveChangesAsync();

            return Ok(keuzevVak);
        }

        private bool KeuzevVakExists(int id)
        {
            return _context.KeuzevVak.Any(e => e.ID == id);
        }
    }
}