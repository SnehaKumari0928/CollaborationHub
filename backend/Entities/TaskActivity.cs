namespace backend.Entities
{
    public class TaskActivity: BaseEntity
    {
        public Guid TaskId { get; set; }
        public Task Task { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public string Action { get; set; } = string.Empty;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }


    }
}
