using System.Collections.Generic;
using Journal.Entities.DomainEntities;

namespace Journal.DataAccess.Interfaces
{
    public interface IMoodTypeRepository
    {
        List<MoodType> GetMoodTypes();

        MoodType GetMoodTypeByID(int MoodTypeID);
    }
}
