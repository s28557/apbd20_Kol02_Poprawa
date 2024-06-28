using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Kol02.Models;

public class Car
{
    public int ID { get; set; }
    public string VIN { get; set; }
    public string Name { get; set; }
    public int Seats { get; set; }
    public int PricePerDay { get; set; }
    public int ModelID { get; set; }
    public int ColorID { get; set; }

    [ForeignKey(nameof(ModelID))]
    public Model Model { get; set; }
    [ForeignKey(nameof(ColorID))]
    public Color Color { get; set; }

    public ICollection<CarRental> CarRentals { get; set; }
}