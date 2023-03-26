namespace Hotel.Data;

public class Room
{
    public Room(int id, string name, int numberOfPeople)
    {
        Id = id;
        Name = name;
        NumberOfPeople = numberOfPeople;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int NumberOfPeople { get; set; }
}