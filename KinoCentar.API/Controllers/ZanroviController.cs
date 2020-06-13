using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KinoCentar.API.EntityModels;

namespace KinoCentar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZanroviController : ControllerBase
    {
        private readonly KinoCentarDbContext _context;

        public ZanroviController(KinoCentarDbContext context)
        {
            _context = context;
        }

        // GET: api/Zanrovi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zanr>>> GetZanr()
        {
            return await _context.Zanr.ToListAsync();
        }

        // GET: api/Zanrovi/SearchByName/{name?}
        [HttpGet]
        [Route("SearchByName/{name?}")]
        public async Task<ActionResult<IEnumerable<Zanr>>> GetZanr(string name = "")
        {
            if (string.IsNullOrEmpty(name))
            {
                return await _context.Zanr.ToListAsync();
            }
            else
            {
                return await _context.Zanr.Where(x => x.Naziv.Contains(name)).ToListAsync();
            }
        }

        // GET: api/Zanrovi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zanr>> GetZanr(int id)
        {
            var zanr = await _context.Zanr.FindAsync(id);

            if (zanr == null)
            {
                return NotFound();
            }

            return zanr;
        }

        // PUT: api/Zanrovi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZanr(int id, Zanr zanr)
        {
            if (id != zanr.Id)
            {
                return BadRequest();
            }

            _context.Entry(zanr).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZanrExists(id))
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

        // POST: api/Zanrovi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Zanr>> PostZanr(Zanr zanr)
        {
            _context.Zanr.Add(zanr);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZanr", new { id = zanr.Id }, zanr);
        }

        // DELETE: api/Zanrovi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Zanr>> DeleteZanr(int id)
        {
            var zanr = await _context.Zanr.FindAsync(id);
            if (zanr == null)
            {
                return NotFound();
            }

            _context.Zanr.Remove(zanr);
            await _context.SaveChangesAsync();

            return zanr;
        }

        private bool ZanrExists(int id)
        {
            return _context.Zanr.Any(e => e.Id == id);
        }
    }
}
