namespace backend.Entities
{
    public class Notification
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
    }
}
