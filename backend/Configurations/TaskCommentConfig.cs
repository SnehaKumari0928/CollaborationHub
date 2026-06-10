using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class TaskCommentConfig: IEntityTypeConfiguration<TaskItem>
    {

        public void Configuration(EntityTypeBuilder<TaskComment> builder)
        {
            builder.ToTable("TaskComments");

            builder.HasKey(ts => ts.Id);

            
        }
    }
}
