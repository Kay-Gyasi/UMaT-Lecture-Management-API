namespace LMSAPI.Rooms;

public record RoomCommand(int Id, string Name, int? Capacity, bool IsLab, bool IsWorkshop);
public record RoomDto(int Id, string Name, int Capacity, bool IsLab, bool IsWorkshop);
public record RoomPageDto(int Id, string Name, int Capacity, bool IsLab, bool IsWorkshop);

[Processor]
public class RoomProcessor
{
    private readonly IRoomRepository _roomRepository;
    private readonly ILogger<RoomProcessor> _logger;

    public RoomProcessor(IRoomRepository roomRepository, ILogger<RoomProcessor> logger)
    {
        _roomRepository = roomRepository;
        _logger = logger;
    }
    
    public async Task<int?> UpsertAsync(RoomCommand command)
    {
        var isNew = command.Id == 0;
        Room? room;

        if (isNew)
        {
            room = Room.Create(command.Name, command.Capacity);
            if (command.IsLab) room.IsLabRoom();
            if (command.IsWorkshop) room.IsWorkshopRoom();
            try
            {
                await _roomRepository.AddAsync(room);
                return room.Id;
            }
            catch (Exception e)
            {
                _logger.LogError("{Message}", e.Message);
                return null;
            }
        }

        room = await _roomRepository.FindByIdAsync(command.Id);
        if(room is null) throw new NullReferenceException();

        room.WithName(command.Name)
            .HasCapacity(command.Capacity);
        if (command.IsLab) room.IsLabRoom();
        if (command.IsWorkshop) room.IsWorkshopRoom();
        
        try
        {
            await _roomRepository.UpdateAsync(room);
            return room.Id;
        }
        catch (Exception e)
        {
            _logger.LogError("{Message}", e.Message);
            return null;
        }
    }

    public async Task<RoomDto> GetAsync(int id)
    {
        var room = await _roomRepository.FindByIdAsync(id);
        if (room is null) throw new NullReferenceException();

        return room.Adapt<RoomDto>();
    }

    public async Task<bool> Exists(string name)
    {
        return await _roomRepository.Exists(name);
    }

    public async Task<PaginatedList<RoomPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _roomRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<RoomPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var room = await _roomRepository.FindByIdAsync(id);
        if (room is null) throw new NullReferenceException();

        await _roomRepository.SoftDeleteAsync(room);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var room = await _roomRepository.FindByIdAsync(id);
        if (room is null) throw new NullReferenceException();

        await _roomRepository.DeleteAsync(room);
    }
}