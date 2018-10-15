using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Journal.DataAccess.Repositories.Context;
using Journal.Entities.DomainEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Journal.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalController : ControllerBase
    {
        private readonly JournalContext _context;

        public JournalController(JournalContext context)
        {
            _context = context;
        }

        // GET: api/Journal
        [HttpGet]
        public IEnumerable<Journals> GetJournals()
        {
            return _context.Journals;
        }

        // GET: api/Journal/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetJournals([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var journals = await _context.Journals.FindAsync(id);

            if (journals == null)
            {
                return NotFound();
            }

            return Ok(journals);
        }

        // PUT: api/Journal/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJournals([FromRoute] int id, [FromBody] Journals journals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != journals.JournalID)
            {
                return BadRequest();
            }

            _context.Entry(journals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JournalsExists(id))
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

        // POST: api/Journal
        [HttpPost]
        public async Task<IActionResult> PostJournals([FromBody] Journals journals)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Journals.Add(journals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJournals", new { id = journals.JournalID }, journals);
        }

        // DELETE: api/Journal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJournals([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var journals = await _context.Journals.FindAsync(id);
            if (journals == null)
            {
                return NotFound();
            }

            _context.Journals.Remove(journals);
            await _context.SaveChangesAsync();

            return Ok(journals);
        }

        private bool JournalsExists(int id)
        {
            return _context.Journals.Any(e => e.JournalID == id);
        }
    }
}