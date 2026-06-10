using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        DbSet<User> Users { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<TeamMember> TeamMembers {  get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<TaskItem> TaskItems { get; set; }
        DbSet<TaskComment> TaskComments { get; set; }
        DbSet<TaskActivity> TaskActivities { get; set; }
        DbSet<ChatRoom> ChatRooms { get; set; }
        DbSet<ChatMessage> ChatMessages { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly);
        }
    }
}
