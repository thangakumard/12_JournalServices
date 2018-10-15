using System.Collections.Generic;
using System.Threading.Tasks;
using Journal.Business.Interfaces;
using Journal.Entities.DomainEntities;
using Microsoft.AspNetCore.Mvc;

namespace Journal.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityBusiness _activityBusiness;

        public ActivityController(IActivityBusiness activityBusiness)
        {
            _activityBusiness = activityBusiness;
        }

        // GET: api/Activity
        [HttpGet]
        public IEnumerable<Activity> GetActivity()
        {
            return _activityBusiness.GetActivities();
        }

        // GET: api/Activity/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivityByID([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var activity = _activityBusiness.GetActivityByID(id);

            if (activity == null)
            {
                return NotFound();
            }

            return Ok(activity);
        }

        //// PUT: api/Activity/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutActivity([FromRoute] int id, [FromBody] Activity activity)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != activity.ActivityID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(activity).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ActivityExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Activity
        //[HttpPost]
        //public async Task<IActionResult> PostActivity([FromBody] Activity activity)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Activity.Add(activity);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetActivity", new { id = activity.ActivityID }, activity);
        //}

        //// DELETE: api/Activity/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteActivity([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var activity = await _context.Activity.FindAsync(id);
        //    if (activity == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Activity.Remove(activity);
        //    await _context.SaveChangesAsync();

        //    return Ok(activity);
        //}

        //private bool ActivityExists(int id)
        //{
        //    return _context.Activity.Any(e => e.ActivityID == id);
        //}
    }
}