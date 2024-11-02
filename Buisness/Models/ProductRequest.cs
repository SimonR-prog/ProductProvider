using System.ComponentModel.DataAnnotations;

namespace Buisness.Models;

public class ProductRequest
{
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public decimal Price { get; set; }
    public string? Category { get; set; }
    public int SkuAmount { get; set; }
}
