namespace Kol02.DTOs;

public class AddClientDto
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

public class AddClientRentalDto
{
    public AddClientDto Client { get; set; }
    public int CardID { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
}