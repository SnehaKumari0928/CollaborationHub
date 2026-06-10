using backend.Entities.Enums;

namespace backend.Entities
{
    public class Project: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
        public ProjectStatus Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
