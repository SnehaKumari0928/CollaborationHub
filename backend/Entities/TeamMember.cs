using backend.Entities.Enums;

namespace backend.Entities
{
    public class TeamMember
    {
        public Guid TeamId { get; set; }
        public Team Team { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public TeamRole Role { get; set; }
        public DateTime JoinedAt { get; set; }

    }
}
