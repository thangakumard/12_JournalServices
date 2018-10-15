using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class JournalMoodTypeMapping : IEntityTypeConfiguration<JournalMoodType>
    {
        public void Configure(EntityTypeBuilder<JournalMoodType> builder)
        {
            builder.ToTable("Journal_MoodType");
            builder.HasKey(x => new { x.JournalID, x.MoodTypeID });
            builder.Property(x => x.JournalID).HasColumnName("JournalID");
            builder.Property(x => x.MoodTypeID).HasColumnName("MoodTypeID");
        }
    }
}
