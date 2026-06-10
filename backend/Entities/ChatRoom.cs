namespace backend.Entities
{
    public class ChatRoom : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
        public ICollection<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
    }
}
