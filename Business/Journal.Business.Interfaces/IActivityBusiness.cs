using System.Collections.Generic;
using Journal.Entities.DomainEntities;

namespace Journal.Business.Interfaces
{
    public interface IActivityBusiness
    {
        List<Activity> GetActivities();

        Activity GetActivityByID(int activityID);

        Activity CreateActivity(Activity activity);

        Activity UpdateActivity(Activity activity);

        bool DeleteActivity(int activityID);
    }
}
