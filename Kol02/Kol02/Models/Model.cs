using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Kol02.Models;

[PrimaryKey(nameof(ID))]
public class Model
{
    public int ID { get; set; }
    [MinLength(2)]
    public string? Name { get; set; }
    public ICollection<Car> Cars { get; set; }
}