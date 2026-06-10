using backend.Entities.Enums;

namespace backend.Entities
{
    public class TaskItem: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid CreatedById {  get; set; }
        public User CreatedBy { get; set; }
        public Guid? AssignedToId { get; set; }
        public User? AssignedTo { get; set; }
        public StatusOfTask Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public ICollection<TaskComment> Comments { get; set; } = new List<TaskComment>();
        public ICollection<TaskActivity> Activities { get; set; }

    }
    
}
