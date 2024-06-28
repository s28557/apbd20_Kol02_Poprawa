namespace Kol02.DTOs;

public class GetClientDto
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public ICollection<GetCLientRentalDto> Rentals { get; set; }
}

public class GetCLientRentalDto
{
    public string Vin { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public int TotalPrice { get; set; }
}