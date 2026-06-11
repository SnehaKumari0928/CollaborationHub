using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class TaskActivityConfig: IEntityTypeConfiguration<TaskActivity>
    {

        public void Configure(EntityTypeBuilder<TaskActivity> builder)
        {
            builder.ToTable("TaskActivities");

            builder.HasKey(ta => ta.Id);

            builder.Property(ta => ta.Action)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(ta => ta.Task)
                .WithMany(t => t.Activities)
                .HasForeignKey(ta => ta.TaskId);

            builder.HasOne(ta => ta.User)
                .WithMany(u => u.Activities)
                .HasForeignKey(ta => ta.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
