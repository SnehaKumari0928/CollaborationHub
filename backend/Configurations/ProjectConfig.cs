using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class ProjectConfig: IEntityTypeConfiguration<Project>
    {

        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.ToTable("Projects");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);

            builder.HasOne( p => p.Team)
                .WithMany(t => t.Projects)
                .HasForeignKey(p => p.TeamId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(p => p.Status)
                .HasConversion<int>();

            builder.Property(p => p.Name)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
