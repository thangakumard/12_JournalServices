using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class MoodTypeMapping : IEntityTypeConfiguration<MoodType>
    {
        public void Configure(EntityTypeBuilder<MoodType> builder)
        {
            builder.ToTable("MoodType");
            builder.HasKey(x => x.MoodTypeID);
            builder.Property(x => x.MoodTypeID).HasColumnName("MoodTypeID");
            builder.Property(x => x.Mood_Type).HasColumnName("MoodType");
            builder.Property(x => x.Description).HasColumnName("Description");
        }
    }
}
