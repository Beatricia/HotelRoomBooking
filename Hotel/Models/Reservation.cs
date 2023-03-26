namespace Hotel.Data;

public class Reservation
{
    public Reservation(DateTime dateFrom, DateTime dateTo, int reservedPeople, int resourceId)
    {
        DateFrom = dateFrom;
        DateTo = dateTo;
        ReservedPeople = reservedPeople;
        ResourceId = resourceId;
    }

    public int Id { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public int ReservedPeople { get; set; }
    public int ResourceId { get; set; }
}