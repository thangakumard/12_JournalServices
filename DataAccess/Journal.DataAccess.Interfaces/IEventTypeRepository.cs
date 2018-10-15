using System.Collections.Generic;
using Journal.Entities.DomainEntities;

namespace Journal.DataAccess.Interfaces
{
    public interface IEventTypeRepository
    {
        List<EventType> GetEventTypes();

        EventType GetEventTypeByID(int EventTypeID);
    }
}
