using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class JournalsMapping : IEntityTypeConfiguration<Journals>
    {
        public void Configure(EntityTypeBuilder<Journals> builder)
        {
            builder.ToTable("Journal");
            builder.HasKey(x => x.JournalID);
            builder.Property(x => x.JournalID).HasColumnName("JournalID");
            builder.Property(x => x.JournalTitle).HasColumnName("JournalTitle");
            builder.Property(x => x.JournalDate).HasColumnName("JournalDate");
            builder.Property(x => x.JournalDescription).HasColumnName("JournalDescription");
            builder.Property(x => x.UserID).HasColumnName("UserID");
            builder.Property(x => x.CreatedOn).HasColumnName("CreatedOn");
        }
    }
}
