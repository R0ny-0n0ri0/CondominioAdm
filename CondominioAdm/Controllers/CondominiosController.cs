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
    public class CondominiosController : ControllerBase
    {
        private readonly CondominioAdmContext _context;

        public CondominiosController(CondominioAdmContext context)
        {
            _context = context;
        }

        // GET: api/Condominios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Condominio>>> GetComdominios()
        {
            return await _context.Comdominios.ToListAsync();
        }

        // GET: api/Condominios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Condominio>> GetCondominio(int id)
        {
            var condominio = await _context.Comdominios.FindAsync(id);

            if (condominio == null)
            {
                return NotFound();
            }

            return condominio;
        }

        // PUT: api/Condominios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondominio(int id, Models.Condominio condominio)
        {
            if (id != condominio.CondominioId)
            {
                return BadRequest();
            }

            _context.Entry(condominio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondominioExists(id))
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

        // POST: api/Condominios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Models.Condominio>> PostCondominio(Models.Condominio condominio)
        {
            _context.Comdominios.Add(condominio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCondominio", new { id = condominio.CondominioId }, condominio);
        }

        // DELETE: api/Condominios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCondominio(int id)
        {
            var condominio = await _context.Comdominios.FindAsync(id);
            if (condominio == null)
            {
                return NotFound();
            }

            _context.Comdominios.Remove(condominio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CondominioExists(int id)
        {
            return _context.Comdominios.Any(e => e.CondominioId == id);
        }
    }
}
