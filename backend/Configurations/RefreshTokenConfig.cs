using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class RefreshTokenConfig: IEntityTypeConfiguration<RefreshToken>
    {

        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable("RefreshTokens");

            builder.HasKey(rf => rf.Id);

            builder.Property(rf => rf.Token)
                .IsRequired();

            builder.HasOne(rf => rf.User)
                .WithMany(u => u.RefreshTokens)
                .HasForeignKey(rf => rf.Id);
        }
    }
}
