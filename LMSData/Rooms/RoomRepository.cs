namespace LMSData.Rooms;

[Repository]
public class RoomRepository : Repository<Room, int>, IRoomRepository
{
    public RoomRepository(AppDbContext context, ILogger<Repository<Room, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface IRoomRepository : IRepository<Room, int> { }