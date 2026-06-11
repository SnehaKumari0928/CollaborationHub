using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class PasswordResetTokenConfig: IEntityTypeConfiguration<PasswordResetToken>
    {
        public void Configure(EntityTypeBuilder<PasswordResetToken> builder)
        {
            builder.ToTable("PasswordResetTokens");

            builder.HasKey(ps => ps.Id);

           builder.Property(ps => ps.Token)
                .IsRequired();
            builder.HasOne(ps => ps.User)
                .WithMany(u => u.PasswordResetTokens)
                .HasForeignKey(ps => ps.UserId);
        }

    }
}
