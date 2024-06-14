using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication19.Data;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudnetsController : ControllerBase
    {
        private readonly WebApplication19Context _context;

        public StudnetsController(WebApplication19Context context)
        {
            _context = context;
        }

        // GET: api/Studnets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Studnet>>> GetStudnet()
        {
          if (_context.Studnet == null)
          {
              return NotFound();
          }
            return await _context.Studnet.ToListAsync();
        }

        // GET: api/Studnets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Studnet>> GetStudnet(int id)
        {
          if (_context.Studnet == null)
          {
              return NotFound();
          }
            var studnet = await _context.Studnet.FindAsync(id);

            if (studnet == null)
            {
                return NotFound();
            }

            return studnet;
        }

        // PUT: api/Studnets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudnet(int id, Studnet studnet)
        {
            if (id != studnet.ID)
            {
                return BadRequest();
            }

            _context.Entry(studnet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudnetExists(id))
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

        // POST: api/Studnets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Studnet>> PostStudnet(Studnet studnet)
        {
          if (_context.Studnet == null)
          {
              return Problem("Entity set 'WebApplication19Context.Studnet'  is null.");
          }
            _context.Studnet.Add(studnet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudnet", new { id = studnet.ID }, studnet);
        }

        // DELETE: api/Studnets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudnet(int id)
        {
            if (_context.Studnet == null)
            {
                return NotFound();
            }
            var studnet = await _context.Studnet.FindAsync(id);
            if (studnet == null)
            {
                return NotFound();
            }

            _context.Studnet.Remove(studnet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudnetExists(int id)
        {
            return (_context.Studnet?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
