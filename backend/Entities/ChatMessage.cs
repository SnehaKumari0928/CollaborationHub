namespace backend.Entities
{
    public class ChatMessage: BaseEntity
    {
        public string MessageTxt { get; set; }
        public Guid ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; }
        public Guid SenderId { get; set; }
        public User Sender { get; set; }
    }
}
