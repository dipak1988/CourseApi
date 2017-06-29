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
    [Route("api/PropedeuseCourses")]
    public class PropedeuseCoursesController : Controller
    {
        private readonly SchoolContext _context;

        public PropedeuseCoursesController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/PropedeuseCourses
        [HttpGet]
        public IEnumerable<PropedeuseCourse> GetPCourses()
        {
            return _context.PCourses;
        }

        // GET: api/PropedeuseCourses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropedeuseCourse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var propedeuseCourse = await _context.PCourses.SingleOrDefaultAsync(m => m.ID == id);

            if (propedeuseCourse == null)
            {
                return NotFound();
            }

            return Ok(propedeuseCourse);
        }

        // PUT: api/PropedeuseCourses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPropedeuseCourse([FromRoute] int id, [FromBody] PropedeuseCourse propedeuseCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propedeuseCourse.ID)
            {
                return BadRequest();
            }

            _context.Entry(propedeuseCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropedeuseCourseExists(id))
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

        // POST: api/PropedeuseCourses
        [HttpPost]
        public async Task<IActionResult> PostPropedeuseCourse([FromBody] PropedeuseCourse propedeuseCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PCourses.Add(propedeuseCourse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PropedeuseCourseExists(propedeuseCourse.ID))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPropedeuseCourse", new { id = propedeuseCourse.ID }, propedeuseCourse);
        }

        // DELETE: api/PropedeuseCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePropedeuseCourse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var propedeuseCourse = await _context.PCourses.SingleOrDefaultAsync(m => m.ID == id);
            if (propedeuseCourse == null)
            {
                return NotFound();
            }

            _context.PCourses.Remove(propedeuseCourse);
            await _context.SaveChangesAsync();

            return Ok(propedeuseCourse);
        }

        private bool PropedeuseCourseExists(int id)
        {
            return _context.PCourses.Any(e => e.ID == id);
        }
    }
}