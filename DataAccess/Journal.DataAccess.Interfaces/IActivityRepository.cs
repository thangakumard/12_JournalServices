using System.Collections.Generic;
using Journal.Entities.DomainEntities;

namespace Journal.DataAccess.Interfaces
{
    public interface IActivityRepository
    {
        List<Activity> GetActivities();

        Activity GetActivityByID(int ActivityID);

        Activity CreateActivity(Activity activity);

        Activity UpdateActivity(Activity activity);

        bool DeleteActivity(int activityID);
    }
}
