namespace LMSData.Rooms;

[Repository]
public class RoomRepository : Repository<Room, int>, IRoomRepository
{
    public RoomRepository(AppDbContext context, ILogger<Repository<Room, int>> logger) 
        : base(context, logger)
    {
    }


    public async Task<bool> Exists(string name)
    {
        return await GetBaseQuery().AnyAsync(x => x.Name == name);
    }
}

public interface IRoomRepository : IRepository<Room, int>
{
    Task<bool> Exists(string name);
}