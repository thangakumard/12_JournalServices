using System;
using System.Collections.Generic;
using Journal.Entities.DomainEntities;

namespace Journal.Entities.CustomEntities
{
    public class JournalCEO
    {
        public int JournalID { get; set; }

        public DateTime JournalDate { get; set; }

        public string JournalTitle { get; set; }

        public string JournalDescription { get; set; }

        public int UserID { get; set; }

        public DateTime CreatedOn { get; set; }

        public List<JournalActivity> Activites { get; set; }

        public List<JournalMoodType> MoodTypes { get; set; }

        public List<JournalEventType> EventTypes { get; set; }
    }
}
