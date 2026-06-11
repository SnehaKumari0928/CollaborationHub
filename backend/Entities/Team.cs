namespace backend.Entities
{
    public class Team: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; } = null!;

        public ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
        public ICollection<Project> Projects { get; set; } = new List<Project>();

        public ICollection<ChatRoom> ChatRooms { get; set; } 

    }
}
