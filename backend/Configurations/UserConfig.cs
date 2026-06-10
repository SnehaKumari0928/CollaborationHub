using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class UserConfig: IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("Users");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FullName).IsRequired().HasMaxLength(100);

            builder.Property(u => u.Email).IsRequired().HasMaxLength(255);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Passwordhash)
                .IsRequired();
        }
    }
}
