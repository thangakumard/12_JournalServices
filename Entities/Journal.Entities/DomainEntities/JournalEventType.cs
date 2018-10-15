using System;

namespace Journal.Entities.DomainEntities
{
    public class JournalEventType
    {
        public int JournalID { get; set; }

        public int EventTypeID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Description { get; set; }
    }
}
