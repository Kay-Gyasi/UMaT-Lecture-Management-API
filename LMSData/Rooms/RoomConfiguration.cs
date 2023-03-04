using LMSData.Helpers;

namespace LMSData.Rooms;

public class RoomConfiguration : DatabaseConfiguration<Room, int>
{
    public override void Configure(EntityTypeBuilder<Room> builder)
    {
        base.Configure(builder);
        builder.ToTable(DomainEntities.Room);
    }
}