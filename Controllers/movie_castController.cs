using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CopAPI.Models;

namespace CopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class movie_castController : ControllerBase
    {
        private readonly movie_castContext _context;

        public movie_castController(movie_castContext context)
        {
            _context = context;
        }

        // GET: api/movie_cast
        [HttpGet]
        public async Task<ActionResult<IEnumerable<movie_cast>>> Getmovie_casts()
        {
            return await _context.movie_casts.ToListAsync();
        }

        // GET: api/movie_cast/5
        [HttpGet("{id}")]
        public async Task<ActionResult<movie_cast>> Getmovie_cast(int id)
        {
            var movie_cast = await _context.movie_casts.FindAsync(id);

            if (movie_cast == null)
            {
                return NotFound();
            }

            return movie_cast;
        }

        // PUT: api/movie_cast/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmovie_cast(int id, movie_cast movie_cast)
        {
            if (id != movie_cast.act_id)
            {
                return BadRequest();
            }

            _context.Entry(movie_cast).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!movie_castExists(id))
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

        // POST: api/movie_cast
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<movie_cast>> Postmovie_cast(movie_cast movie_cast)
        {
            _context.movie_casts.Add(movie_cast);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmovie_cast", new { id = movie_cast.act_id }, movie_cast);
        }

        // DELETE: api/movie_cast/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<movie_cast>> Deletemovie_cast(int id)
        {
            var movie_cast = await _context.movie_casts.FindAsync(id);
            if (movie_cast == null)
            {
                return NotFound();
            }

            _context.movie_casts.Remove(movie_cast);
            await _context.SaveChangesAsync();

            return movie_cast;
        }

        private bool movie_castExists(int id)
        {
            return _context.movie_casts.Any(e => e.act_id == id);
        }
    }
}
