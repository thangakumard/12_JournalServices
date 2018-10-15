using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Journal.DataAccess.Repositories.Context;
using Journal.Entities.DomainEntities;

namespace Journal.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoodTypeController : ControllerBase
    {
        private readonly JournalContext _context;

        public MoodTypeController(JournalContext context)
        {
            _context = context;
        }

        // GET: api/MoodType
        [HttpGet]
        public IEnumerable<MoodType> GetMoodType()
        {
            return _context.MoodType;
        }

        // GET: api/MoodType/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMoodType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var moodType = await _context.MoodType.FindAsync(id);

            if (moodType == null)
            {
                return NotFound();
            }

            return Ok(moodType);
        }

        // PUT: api/MoodType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoodType([FromRoute] int id, [FromBody] MoodType moodType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != moodType.MoodTypeID)
            {
                return BadRequest();
            }

            _context.Entry(moodType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoodTypeExists(id))
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

        // POST: api/MoodType
        [HttpPost]
        public async Task<IActionResult> PostMoodType([FromBody] MoodType moodType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MoodType.Add(moodType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoodType", new { id = moodType.MoodTypeID }, moodType);
        }

        // DELETE: api/MoodType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoodType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var moodType = await _context.MoodType.FindAsync(id);
            if (moodType == null)
            {
                return NotFound();
            }

            _context.MoodType.Remove(moodType);
            await _context.SaveChangesAsync();

            return Ok(moodType);
        }

        private bool MoodTypeExists(int id)
        {
            return _context.MoodType.Any(e => e.MoodTypeID == id);
        }
    }
}