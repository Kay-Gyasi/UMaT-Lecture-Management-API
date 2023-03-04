namespace LMSData.Rooms;

public class Room : DomainEntity<int>
{
    private Room(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }
    
    public string Name { get; private set; }    
    public int Capacity { get; private set; }

    private readonly List<Lecture> _lectures = new();
    public IEnumerable<Lecture> Lectures => _lectures.AsReadOnly();

    public static Room Create(string name, int capacity)
        => new Room(name, capacity);

    public Room WithName(string name)
    {
        Name = name;
        return this;
    }

    public Room HasCapacity(int capacity)
    {
        Capacity = capacity;
        return this;
    }
}