using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class TeamMemberConfig: IEntityTypeConfiguration<TeamMember>
    {

      public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.ToTable("TeamMembers");

            builder.Property(tm => tm.Role).IsRequired();

            builder.HasOne(tm => tm.User)
                 .WithMany(u => u.TeamMembers)
                 .HasForeignKey(tm => tm.UserId);

            builder.HasOne(tm => tm.Team)
                .WithMany(t => t.TeamMembers)
                .HasForeignKey(tm => tm.TeamId);

            builder.Property(tm => tm.Role)
                .HasConversion<int>();
        } 
    }
}
