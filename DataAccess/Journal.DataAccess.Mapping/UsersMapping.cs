using Journal.Entities.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Journal.DataAccess.Mapping
{
    public class UsersMapping : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.UserID).HasColumnName("UserID");
            builder.Property(x => x.UserName).HasColumnName("UserName");
            builder.Property(x => x.FirstName).HasColumnName("FirstName");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.Password).HasColumnName("Password");
            builder.Property(x => x.EmailID).HasColumnName("EmailID");
            builder.Property(x => x.Mobile).HasColumnName("Mobile");
            builder.Property(x => x.IsActive).HasColumnName("IsActive");
        }
    }
}
