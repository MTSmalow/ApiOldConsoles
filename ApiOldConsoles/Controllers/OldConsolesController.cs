using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiOldConsoles.Data;
using ApiOldConsoles.Models;

namespace ApiOldConsoles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OldConsolesController : ControllerBase
    {
        private readonly OldConContext _context;

        public OldConsolesController(OldConContext context)
        {
            _context = context;
        }

        // GET: api/OldConsoles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OldConsole>>> GetOldConsole()
        {
          if (_context.OldConsole == null)
          {
              return NotFound();
          }
            return await _context.OldConsole.ToListAsync();
        }

        // GET: api/OldConsoles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OldConsole>> GetOldConsole(int id)
        {
          if (_context.OldConsole == null)
          {
              return NotFound();
          }
            var oldConsole = await _context.OldConsole.FindAsync(id);

            if (oldConsole == null)
            {
                return NotFound();
            }

            return oldConsole;
        }

        // PUT: api/OldConsoles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOldConsole(int id, OldConsole oldConsole)
        {
            if (id != oldConsole.Id)
            {
                return BadRequest();
            }

            _context.Entry(oldConsole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OldConsoleExists(id))
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

        // POST: api/OldConsoles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OldConsole>> PostOldConsole(OldConsole oldConsole)
        {
          if (_context.OldConsole == null)
          {
              return Problem("Entity set 'OldConContext.OldConsole'  is null.");
          }
            _context.OldConsole.Add(oldConsole);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOldConsole", new { id = oldConsole.Id }, oldConsole);
        }

        // DELETE: api/OldConsoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOldConsole(int id)
        {
            if (_context.OldConsole == null)
            {
                return NotFound();
            }
            var oldConsole = await _context.OldConsole.FindAsync(id);
            if (oldConsole == null)
            {
                return NotFound();
            }

            _context.OldConsole.Remove(oldConsole);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OldConsoleExists(int id)
        {
            return (_context.OldConsole?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
