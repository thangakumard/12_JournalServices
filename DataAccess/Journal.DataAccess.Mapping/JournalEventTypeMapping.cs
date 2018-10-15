using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class JournalEventTypeMapping : IEntityTypeConfiguration<JournalEventType>
    {
        public void Configure(EntityTypeBuilder<JournalEventType> builder)
        {
            builder.ToTable("Journal_EventType");
            builder.HasKey(x => new { x.JournalID, x.EventTypeID });
            builder.Property(x => x.JournalID).HasColumnName("JournalID");
            builder.Property(x => x.EventTypeID).HasColumnName("EventTypeID");
        }
    }
}
