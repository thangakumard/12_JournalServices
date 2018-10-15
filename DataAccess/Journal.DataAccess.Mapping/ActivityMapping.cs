using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class ActivityMapping : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity");
            builder.HasKey(x => x.ActivityID);
            builder.Property(x => x.ActivityID).HasColumnName("ActivityID");
            builder.Property(x => x.ActivityName).HasColumnName("ActivityName");
            builder.Property(x => x.Description).HasColumnName("Description");
        }
    }
}
