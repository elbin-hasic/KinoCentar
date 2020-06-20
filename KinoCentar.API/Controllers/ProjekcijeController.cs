using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KinoCentar.API.EntityModels;
using Microsoft.AspNetCore.Authorization;

namespace KinoCentar.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjekcijeController : ControllerBase
    {
        private readonly KinoCentarDbContext _context;

        public ProjekcijeController(KinoCentarDbContext context)
        {
            _context = context;
        }

        // GET: api/Projekcije
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Projekcija>>> GetProjekcija()
        {
            return await _context.Projekcija
                        .Include(x => x.Film).AsNoTracking()
                        .Include(x => x.Sala).AsNoTracking()
                        .ToListAsync();
        }

        // GET: api/Projekcije/SearchByName/{name?}
        [HttpGet]
        [Route("SearchByName/{name?}")]
        public async Task<ActionResult<IEnumerable<Projekcija>>> GetProjekcija(string name = "")
        {
            if (string.IsNullOrEmpty(name))
            {
                return await _context.Projekcija
                            .Include(x => x.Film).AsNoTracking()
                            .Include(x => x.Sala).AsNoTracking()
                            .ToListAsync();
            }
            else
            {
                return await _context.Projekcija
                            .Include(x => x.Film).AsNoTracking()
                            .Include(x => x.Sala).AsNoTracking()
                            .Where(x => x.Film.Naslov.Contains(name)).ToListAsync();
            }
        }

        // GET: api/Projekcije/ActiveList
        [HttpGet]
        [Route("ActiveList")]
        public async Task<ActionResult<IEnumerable<Projekcija>>> GetAktivneProjekcije()
        {
            var dtn = DateTime.Now.Date;
            return await _context.Projekcija
                            .Include(x => x.Film).AsNoTracking()
                            .Include(x => x.Sala).AsNoTracking()
                            .Where(x => x.VrijediOd.Date <= dtn && x.VrijediDo.Date >= dtn).ToListAsync();
        }

        // GET: api/Projekcije/RecommendedList/{userName}
        [HttpGet]
        [Route("RecommendedList/{userName}")]
        public async Task<ActionResult<IEnumerable<Projekcija>>> GetPreporuceneProjekcije(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return BadRequest();
            }

            var dtn = DateTime.Now.Date;
            return await _context.Projekcija
                            .Include(x => x.Film).AsNoTracking()
                            .Include(x => x.Sala).AsNoTracking()
                            .Where(x => x.VrijediOd.Date <= dtn && x.VrijediDo.Date >= dtn).ToListAsync();
        }

        // GET: api/Projekcije/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Projekcija>> GetProjekcija(int id)
        {
            var projekcija = await _context.Projekcija.FindAsync(id);

            if (projekcija == null)
            {
                return NotFound();
            }

            return projekcija;
        }

        // PUT: api/Projekcije/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjekcija(int id, Projekcija projekcija)
        {
            if (id != projekcija.Id)
            {
                return BadRequest();
            }

            _context.Entry(projekcija).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjekcijaExists(id))
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

        // POST: api/Projekcije
        [HttpPost]
        public async Task<ActionResult<Projekcija>> PostProjekcija(Projekcija projekcija)
        {
            _context.Projekcija.Add(projekcija);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProjekcija", new { id = projekcija.Id }, projekcija);
        }

        // DELETE: api/Projekcije/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Projekcija>> DeleteProjekcija(int id)
        {
            var projekcija = await _context.Projekcija.FindAsync(id);
            if (projekcija == null)
            {
                return NotFound();
            }

            _context.Projekcija.Remove(projekcija);
            await _context.SaveChangesAsync();

            return projekcija;
        }

        private bool ProjekcijaExists(int id)
        {
            return _context.Projekcija.Any(e => e.Id == id);
        }
    }
}
