using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kol02.Models;

[PrimaryKey(nameof(ID))]
public class CarRental
{
    public int ID{ get; set; }
    public int CLientID { get; set; }
    public int CarID { get; set; }
    public DateTime DateFrom { get; set; }
    public DateTime DateTo { get; set; }
    public int TotalPrice { get; set; }
    public int Discount { get; set; }

    [ForeignKey(nameof(CLientID))]
    public Client Client { get; set; }
    [ForeignKey(nameof(CarID))]
    public Car Car { get; set; }
}