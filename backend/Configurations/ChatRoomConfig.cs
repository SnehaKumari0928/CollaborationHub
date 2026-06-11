using backend.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configurations
{
    public class ChatRoomConfig: IEntityTypeConfiguration<ChatRoom>
    {

        public void Configure(EntityTypeBuilder<ChatRoom> builder)
        {
            builder.ToTable("ChatRooms");
            builder.HasKey(cr => cr.Id);

            builder.Property(cr => cr.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(cr => cr.Team)
                .WithMany(t => t.ChatRooms)
                .HasForeignKey(cr => cr.TeamId);

        }
    }
}
