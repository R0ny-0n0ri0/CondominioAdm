using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CondominioAdm.Context;
using CondominioAdm.Models;

namespace CondominioAdm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliasController : ControllerBase
    {
        private readonly CondominioAdmContext _context;

        public FamiliasController(CondominioAdmContext context)
        {
            _context = context;
        }

        // GET: api/Familias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Familia>>> GetFamilias()
        {
            return await _context.Familias.ToListAsync();
        }

        // GET: api/Familias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Familia>> GetFamilia(int id)
        {
            var familia = await _context.Familias.FindAsync(id);

            if (familia == null)
            {
                return NotFound();
            }

            return familia;
        }

        // PUT: api/Familias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamilia(int id, Familia familia)
        {
            if (id != familia.FamiliaId)
            {
                return BadRequest();
            }

            _context.Entry(familia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamiliaExists(id))
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

        // POST: api/Familias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Familia>> PostFamilia(Familia familia)
        {
            _context.Familias.Add(familia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFamilia", new { id = familia.FamiliaId }, familia);
        }

        // DELETE: api/Familias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFamilia(int id)
        {
            var familia = await _context.Familias.FindAsync(id);
            if (familia == null)
            {
                return NotFound();
            }

            _context.Familias.Remove(familia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FamiliaExists(int id)
        {
            return _context.Familias.Any(e => e.FamiliaId == id);
        }
    }
}
