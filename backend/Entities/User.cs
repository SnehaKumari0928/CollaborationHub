using Microsoft.AspNetCore.Components.Web;

namespace backend.Entities
{
    public class User: BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string Passwordhash = string.Empty;
        public string? ProfileImageUrl { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<Team> CreatedTeams { get; set; } = new List<Team>();

        public ICollection<TeamMember> TeamMembers {  get; set; } = new List<TeamMember>();

        public ICollection<TaskItem> CreatedTasks { get; set; } = new List<TaskItem>();
        public ICollection<TaskItem> AssignedTasks { get; set; } = new List<TaskItem>();
        public ICollection<TaskComment> Comments { get; set; } = new List<TaskComment>();
        public ICollection<TaskActivity> Activities { get; set; } = new List<TaskActivity>();
        public ICollection<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
        public ICollection<TaskActivity> TaskActivities { get; set; } = new List<TaskActivity>();
    }

    }
}
