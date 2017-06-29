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
    [Route("api/MTCourses")]
    public class MTCoursesController : Controller
    {
        private readonly SchoolContext _context;

        public MTCoursesController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/MTCourses
        [HttpGet]
        public IEnumerable<MTCourse> GetMtCourses()
        {
            return _context.MtCourses;
        }

        // GET: api/MTCourses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMTCourse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mTCourse = await _context.MtCourses.SingleOrDefaultAsync(m => m.ID == id);

            if (mTCourse == null)
            {
                return NotFound();
            }

            return Ok(mTCourse);
        }

        // PUT: api/MTCourses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMTCourse([FromRoute] int id, [FromBody] MTCourse mTCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mTCourse.ID)
            {
                return BadRequest();
            }

            _context.Entry(mTCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MTCourseExists(id))
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

        // POST: api/MTCourses
        [HttpPost]
        public async Task<IActionResult> PostMTCourse([FromBody] MTCourse mTCourse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MtCourses.Add(mTCourse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MTCourseExists(mTCourse.ID))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMTCourse", new { id = mTCourse.ID }, mTCourse);
        }

        // DELETE: api/MTCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMTCourse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mTCourse = await _context.MtCourses.SingleOrDefaultAsync(m => m.ID == id);
            if (mTCourse == null)
            {
                return NotFound();
            }

            _context.MtCourses.Remove(mTCourse);
            await _context.SaveChangesAsync();

            return Ok(mTCourse);
        }

        private bool MTCourseExists(int id)
        {
            return _context.MtCourses.Any(e => e.ID == id);
        }
    }
}