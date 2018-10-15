using System;

namespace Journal.Entities.DomainEntities
{
    public class Journals
    {
        public int JournalID { get; set; }

        public DateTime JournalDate { get; set; }

        public string JournalTitle { get; set; }

        public string JournalDescription { get; set; }

        public int UserID { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
