using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Journal.DataAccess.Mapping
{
    public class EventTypeMapping : IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            builder.ToTable("EventType");
            builder.HasKey(x => x.EventTypeID);
            builder.Property(x => x.EventTypeID).HasColumnName("EventTypeID");
            builder.Property(x => x.Event_Type).HasColumnName("EventType");
            builder.Property(x => x.Description).HasColumnName("Description");
        }
    }
}
