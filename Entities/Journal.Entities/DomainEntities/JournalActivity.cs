using System;

namespace Journal.Entities.DomainEntities
{
    public class JournalActivity
    {
        public int JournalID { get; set; }

        public int ActivityID { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Description { get; set; }
    }
}
