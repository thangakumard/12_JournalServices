using System.Collections.Generic;
using Journal.Business.Interfaces;
using Journal.DataAccess.Interfaces;
using Journal.Entities.DomainEntities;

namespace Journal.Business
{
    public class ActivityBusiness : IActivityBusiness
    {
        private readonly IActivityRepository _ActivityRespository;

        public ActivityBusiness(IActivityRepository ActivityRespository)
        {
            _ActivityRespository = ActivityRespository;
        }

        public List<Activity> GetActivities()
        {
            return _ActivityRespository.GetActivities();
        }

        public Activity GetActivityByID(int activityID)
        {
            return _ActivityRespository.GetActivityByID(activityID);
        }

        public Activity CreateActivity(Activity activity)
        {
            throw new System.NotImplementedException();
        }

        public Activity UpdateActivity(Activity activity)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteActivity(int activityID)
        {
            throw new System.NotImplementedException();
        }
       
    }
}
