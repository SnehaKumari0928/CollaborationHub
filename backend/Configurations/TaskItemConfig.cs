using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class TaskItemConfig: IEntityTypeConfiguration<TaskItem>
    {

        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.ToTable("TaskItems");

            builder.HasKey(ti => ti.Id);

            builder.Property(ti => ti.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(ti => ti.Status)
                .HasConversion<int>();

            builder.Property(ti => ti.Priority)
                .HasConversion<int>();



            builder.HasOne(ti => ti.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(ti => ti.ProjectId);

            builder.HasOne(ti => ti.CreatedBy)
                .WithMany(u => u.CreatedTasks)
                .HasForeignKey(ti => ti.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ti => ti.AssignedTo)
                .WithMany(u => u.AssignedTasks)
                .HasForeignKey(ti => ti.AssignedToId)
                .OnDelete(DeleteBehavior.SetNull);



        }
    }
}
