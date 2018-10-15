using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Journal.DataAccess.Interfaces;
using Journal.DataAccess.Repositories.Context;
using Journal.Entities.DomainEntities;

namespace Journal.DataAccess.Repositories.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly JournalContext _context;

        public ActivityRepository(JournalContext context)
        {
            _context = context;
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = new List<Activity>();
            using (var context = new JournalContext())
            {
                activities = context.Activity.ToList();
            }
            return activities;
        }

        public Activity GetActivityByID(int activityId)
        {
            Activity activity = new Activity();
            using (var context = new JournalContext())
            {
                activity = context.Activity.Where(a => a.ActivityID == activityId).FirstOrDefault();
            }
            return activity;
        }

        public async Task<Activity> CreateActivity(Activity activity)
        {
            using (var context = new JournalContext())
            {
                context.Activity.Add(activity);
                return await context.SaveChangesAsync();
            }          
        }

        public bool DeleteActivity(int activityID)
        {
            throw new System.NotImplementedException();
        }

        public Activity UpdateActivity(Activity activity)
        {
            throw new System.NotImplementedException();
        }
    }
}
