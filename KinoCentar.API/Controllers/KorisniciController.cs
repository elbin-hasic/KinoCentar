using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KinoCentar.API.EntityModels;
using KinoCentar.Shared.Models;

namespace KinoCentar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly KinoCentarDbContext _context;

        public KorisniciController(KinoCentarDbContext context)
        {
            _context = context;
        }

        // GET: api/Korisnici
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Korisnik>>> GetKorisnik()
        {
            return await _context.Korisnik.Include(i => i.TipKorisnika).AsNoTracking().ToListAsync();
        }

        // GET: api/Korisnici/SearchByName/{firstName}/{lastName}
        [HttpGet]
        [Route("SearchByName/{firstName}/{lastName}")]
        public async Task<ActionResult<IEnumerable<Korisnik>>> GetKorisnik(string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && firstName != "*" && !string.IsNullOrEmpty(lastName) && lastName != "*")
            {
                return await _context.Korisnik.Where(x => x.Ime.Contains(firstName) || x.Prezime.Contains(lastName)).Include(i => i.TipKorisnika).AsNoTracking().ToListAsync();
            }
            else if (!string.IsNullOrEmpty(firstName) && firstName != "*")
            {
                return await _context.Korisnik.Where(x => x.Ime.Contains(firstName)).Include(i => i.TipKorisnika).AsNoTracking().ToListAsync();
            }
            else if (!string.IsNullOrEmpty(lastName) && lastName != "*")
            {
                return await _context.Korisnik.Where(x => x.Prezime.Contains(lastName)).Include(i => i.TipKorisnika).AsNoTracking().ToListAsync();
            }
            else
            {
                return await _context.Korisnik.Include(i => i.TipKorisnika).AsNoTracking().ToListAsync();
            }
        }

        // GET: api/Korisnici/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Korisnik>> GetKorisnik(int id)
        {
            var korisnik = await _context.Korisnik.FindAsync(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return korisnik;
        }

        // GET: api/Korisnici/GetByUserName/{userName}
        [HttpGet("GetByUserName/{userName}")]
        public async Task<ActionResult<Korisnik>> GetKorisnik(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return BadRequest();
            }

            var korisnik = await _context.Korisnik
                                 .Include(x => x.TipKorisnika).AsNoTracking()
                                 .FirstOrDefaultAsync(x => x.KorisnickoIme.ToLower()
                                 .Equals(userName.ToLower()));
            if (korisnik == null)
            {
                return NotFound();
            }

            return korisnik;
        }

        // PUT: api/Korisnici/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKorisnik(int id, Korisnik korisnik)
        {
            if (id != korisnik.Id)
            {
                return BadRequest();
            }

            _context.Entry(korisnik).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KorisnikExists(id))
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

        // POST: api/Korisnici
        [HttpPost]
        public async Task<ActionResult<Korisnik>> PostKorisnik(Korisnik korisnik)
        {
            _context.Korisnik.Add(korisnik);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKorisnik", new { id = korisnik.Id }, korisnik);
        }

        // DELETE: api/Korisnici/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Korisnik>> DeleteKorisnik(int id)
        {
            var korisnik = await _context.Korisnik.FindAsync(id);
            if (korisnik == null)
            {
                return NotFound();
            }

            _context.Korisnik.Remove(korisnik);
            await _context.SaveChangesAsync();

            return korisnik;
        }

        private bool KorisnikExists(int id)
        {
            return _context.Korisnik.Any(e => e.Id == id);
        }
    }
}
