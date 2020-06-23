using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KinoCentar.API.EntityModels;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace KinoCentar.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AnketeController : ControllerBase
    {
        private readonly KinoCentarDbContext _context;

        public AnketeController(KinoCentarDbContext context)
        {
            _context = context;
        }

        // GET: api/Ankete
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anketa>>> GetAnketa()
        {
            return await _context.Anketa
                            .Include(x => x.Korisnik).AsNoTracking()
                            .Include(x => x.Odgovori).AsNoTracking()
                            .ToListAsync();
        }

        // GET: api/Ankete/SearchByName/{name?}
        [HttpGet]
        [Route("SearchByName/{name?}")]
        public async Task<ActionResult<IEnumerable<Anketa>>> GetAnketa(string name = "")
        {
            if (string.IsNullOrEmpty(name))
            {
                return await _context.Anketa
                                .Include(x => x.Korisnik).AsNoTracking()
                                .Include(x => x.Odgovori).AsNoTracking()
                                .ToListAsync();
            }
            else
            {
                return await _context.Anketa
                                .Include(x => x.Korisnik).AsNoTracking()
                                .Include(x => x.Odgovori).AsNoTracking()
                                .Where(x => x.Naslov.Contains(name)).ToListAsync();
            }
        }

        // GET: api/Ankete/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Anketa>> GetAnketa(int id)
        {
            var anketa = await _context.Anketa
                                    .Include(x => x.Korisnik).AsNoTracking()
                                    .Include(x => x.Odgovori).AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.Id == id);

            if (anketa == null)
            {
                return NotFound();
            }

            return anketa;
        }

        // PUT: api/Ankete/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnketa(int id, Anketa anketa)
        {
            if (id != anketa.Id)
            {
                return BadRequest();
            }

            if (anketa.Odgovori != null)
            {
                foreach (var odgovor in anketa.Odgovori)
                {
                    if (odgovor.Id == 0)
                    {
                        _context.AnketaOdgovor.Add(odgovor);
                    }
                    else
                    {
                        _context.Entry(odgovor).State = EntityState.Modified;
                    }
                }
            }

            _context.Entry(anketa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnketaExists(id))
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

        // POST: api/Ankete
        [HttpPost]
        public async Task<ActionResult<Anketa>> PostAnketa(Anketa anketa)
        {
            if (anketa.Odgovori != null)
            {
                foreach (var odgovor in anketa.Odgovori)
                {
                    odgovor.Anketa = anketa;
                    _context.AnketaOdgovor.Add(odgovor);
                }
            }

            _context.Anketa.Add(anketa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnketa", new { id = anketa.Id }, anketa);
        }

        // PUT: api/Ankete/5
        [HttpPut]
        [Route("Close/{id}")]
        public async Task<ActionResult<Anketa>> CloseRezervacija(int id)
        {
            var anketa = await _context.Anketa.FindAsync(id);
            if (anketa == null)
            {
                return NotFound();
            }

            if (anketa.ZakljucenoDatum != null)
            {
                return StatusCode((int)HttpStatusCode.Conflict, "Navedena anketa je već zaklučana!");
            }

            anketa.ZakljucenoDatum = DateTime.Now;
            await _context.SaveChangesAsync();

            return anketa;
        }

        // DELETE: api/Ankete/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Anketa>> DeleteAnketa(int id)
        {
            var anketa = await _context.Anketa.FindAsync(id);
            if (anketa == null)
            {
                return NotFound();
            }

            _context.Anketa.Remove(anketa);
            await _context.SaveChangesAsync();

            return anketa;
        }

        private bool AnketaExists(int id)
        {
            return _context.Anketa.Any(e => e.Id == id);
        }
    }
}
