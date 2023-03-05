namespace LMSAPI.Rooms;

public record RoomCommand(int Id, string Name, int Capacity);
public record RoomDto(int Id, string Name, int Capacity);
public record RoomPageDto(int Id, string Name, int Capacity);

[Processor]
public class RoomProcessor
{
    private readonly IRoomRepository _roomRepository;

    public RoomProcessor(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }
    
    public async Task<int> UpsertAsync(RoomCommand command)
    {
        var isNew = command.Id == 0;
        Room? room;

        if (isNew)
        {
            room = Room.Create(command.Name, command.Capacity);
            await _roomRepository.AddAsync(room);
            return room.Id;
        }

        room = await _roomRepository.FindByIdAsync(command.Id);
        if(room is null) throw new NullReferenceException();

        room.WithName(command.Name)
            .HasCapacity(command.Capacity);
        await _roomRepository.UpdateAsync(room);
        return room.Id;
    }

    public async Task<RoomDto> GetAsync(int id)
    {
        var room = await _roomRepository.FindByIdAsync(id);
        if (room is null) throw new NullReferenceException();

        return room.Adapt<RoomDto>();
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