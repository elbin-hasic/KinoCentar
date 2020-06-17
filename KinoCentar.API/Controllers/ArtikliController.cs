using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KinoCentar.API.EntityModels;
using System.Net;

namespace KinoCentar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtikliController : ControllerBase
    {
        private readonly KinoCentarDbContext _context;

        public ArtikliController(KinoCentarDbContext context)
        {
            _context = context;
        }

        // GET: api/Artikli
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artikal>>> GetArtikal()
        {
            return await _context.Artikal.ToListAsync();
        }

        // GET: api/Artikli/SearchByName/{name?}
        [HttpGet]
        [Route("SearchByName/{name?}")]
        public async Task<ActionResult<IEnumerable<Artikal>>> GetArtikal(string name = "")
        {
            if (string.IsNullOrEmpty(name))
            {
                return await _context.Artikal.ToListAsync();
            }
            else
            {
                return await _context.Artikal.Where(x => x.Naziv.Contains(name)).ToListAsync();
            }
        }

        // GET: api/Artikli/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artikal>> GetArtikal(int id)
        {
            var artikal = await _context.Artikal.FindAsync(id);

            if (artikal == null)
            {
                return NotFound();
            }

            return artikal;
        }

        // PUT: api/Artikli/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtikal(int id, Artikal artikal)
        {
            if (id != artikal.Id)
            {
                return BadRequest();
            }

            var a = await _context.Artikal.FirstOrDefaultAsync(x => x.Id != artikal.Id &&
                                                                    x.Sifra.ToLower().Equals(artikal.Sifra.ToLower()));
            if (a != null)
            {
                return StatusCode((int)HttpStatusCode.Conflict, "Artikal sa navedenom šifrom već postoji!");
            }

            _context.Entry(artikal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtikalExists(id))
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

        // POST: api/Artikli
        [HttpPost]
        public async Task<ActionResult<Artikal>> PostArtikal(Artikal artikal)
        {
            if (string.IsNullOrEmpty(artikal.Sifra))
            {
                return BadRequest();
            }

            var a = await _context.Artikal.FirstOrDefaultAsync(x => x.Sifra.ToLower().Equals(artikal.Sifra.ToLower()));
            if (a != null)
            {
                return StatusCode((int)HttpStatusCode.Conflict, "Artikal sa navedenom šifrom već postoji!");
            }

            _context.Artikal.Add(artikal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtikal", new { id = artikal.Id }, artikal);
        }

        // DELETE: api/Artikli/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Artikal>> DeleteArtikal(int id)
        {
            var artikal = await _context.Artikal.FindAsync(id);
            if (artikal == null)
            {
                return NotFound();
            }

            _context.Artikal.Remove(artikal);
            await _context.SaveChangesAsync();

            return artikal;
        }

        private bool ArtikalExists(int id)
        {
            return _context.Artikal.Any(e => e.Id == id);
        }
    }
}
