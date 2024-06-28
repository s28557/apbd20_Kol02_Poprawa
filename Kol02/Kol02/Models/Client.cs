using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Kol02.Models;

[PrimaryKey(nameof(ID))]
public class Client
{
    public static int ID { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string? Address { get; set; }
    public ICollection<CarRental> CarRentals { get; set; }
}