using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class TeamConfig: IEntityTypeConfiguration<Team>
    {

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Teams");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
            builder.Property(t => t.Description).HasMaxLength(500);

            builder.HasOne(t => t.CreatedBy)
                .WithMany(u => u.CreatedTeams)
                .HasForeignKey(t => t.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
