namespace LMSData.Rooms;

public class Room : DomainEntity<int>
{
    private Room() { }
    private Room(string name, int? capacity)
    {
        Name = name;
        Capacity = capacity;
    }
    
    public string Name { get; private set; }
    public int? Capacity { get; private set; }
    public bool IsLab { get; private set; }
    public bool IsWorkshop { get; private set; }

    private readonly List<Session> _sessions = new();
    public IEnumerable<Session> Sessions => _sessions.AsReadOnly();

    public static Room Create(string name, int? capacity)
        => new Room(name, capacity);

    public Room WithName(string name)
    {
        Name = name;
        return this;
    }

    public Room HasCapacity(int? capacity)
    {
        Capacity = capacity;
        return this;
    }

    public Room IsLabRoom()
    {
        IsLab = true;
        return this;
    }
    
    public Room IsWorkshopRoom()
    {
        IsWorkshop = true;
        return this;
    }
}