using Microsoft.EntityFrameworkCore;

namespace Kol02.Models;

[PrimaryKey(nameof(ID))]
public class Color
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public ICollection<Car> Cars { get; set; }
}