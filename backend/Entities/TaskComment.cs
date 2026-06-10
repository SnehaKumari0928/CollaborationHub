namespace backend.Entities
{
    public class TaskComment: BaseEntity
    {

        public string CommentText { get; set; } = string.Empty; 
        public Guid TaskId { get; set; }
        public TaskItem Task { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
    

    }
}
