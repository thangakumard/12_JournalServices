using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class JournalActivityMapping : IEntityTypeConfiguration<JournalActivity>
    {
        public void Configure(EntityTypeBuilder<JournalActivity> builder)
        {
            builder.ToTable("Journal_Activity");
            builder.HasKey(x => new { x.JournalID, x.ActivityID });
            builder.Property(x => x.JournalID).HasColumnName("JournalID");
            builder.Property(x => x.ActivityID).HasColumnName("ActivityID");
            builder.Property(x => x.StartTime).HasColumnName("StartTime");
            builder.Property(x => x.EndTime).HasColumnName("EndTime");
            builder.Property(x => x.Description).HasColumnName("Description");
        }
    }
}
