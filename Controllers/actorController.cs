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
    public class actorController : ControllerBase
    {
        private readonly actorContext _context;

        public actorController(actorContext context)
        {
            _context = context;
        }

        // GET: api/actor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<actor>>> Getactors()
        {
            return await _context.actors.ToListAsync();
        }

        // GET: api/actor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<actor>> Getactor(int id)
        {
            var actor = await _context.actors.FindAsync(id);

            if (actor == null)
            {
                return NotFound();
            }

            return actor;
        }

        // PUT: api/actor/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putactor(int id, actor actor)
        {
            if (id != actor.act_id)
            {
                return BadRequest();
            }

            _context.Entry(actor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!actorExists(id))
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

        // POST: api/actor
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<actor>> Postactor(actor actor)
        {
            _context.actors.Add(actor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getactor", new { id = actor.act_id }, actor);
        }

        // DELETE: api/actor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<actor>> Deleteactor(int id)
        {
            var actor = await _context.actors.FindAsync(id);
            if (actor == null)
            {
                return NotFound();
            }

            _context.actors.Remove(actor);
            await _context.SaveChangesAsync();

            return actor;
        }

        private bool actorExists(int id)
        {
            return _context.actors.Any(e => e.act_id == id);
        }
    }
}
