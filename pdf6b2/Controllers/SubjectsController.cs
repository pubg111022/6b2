using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pdf6b2.Interfaces;
using pdf6b2.Models;
using pdf6b2.Services;

namespace pdf6b2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly StudentDbContext _context;
        private readonly SubjectService _subjectService;
        public SubjectsController( SubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        // GET: api/Subjects
        [HttpGet]
        public IEnumerable<Subject> GetSubjects()
        {
            List<Subject> s = _subjectService.GetSubject();
            return s;
        }

        // GET: api/Subjects/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subject = await _context.Subjects.FindAsync(id);

            if (subject == null)
            {
                return NotFound();
            }

            return Ok(subject);
        }

        // PUT: api/Subjects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubject([FromRoute] int id, [FromBody] Subject subject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != subject.Id)
            {
                return BadRequest();
            }

            _context.Entry(subject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectExists(id))
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

        // POST: api/Subjects
        [HttpPost]
        public async Task<IActionResult> PostSubject([FromBody] Subject subject)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubject", new { id = subject.Id }, subject);
        }

        // DELETE: api/Subjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubject([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }

            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();

            return Ok(subject);
        }

        private bool SubjectExists(int id)
        {
            return _context.Subjects.Any(e => e.Id == id);
        }
    }
}