using System.ComponentModel.DataAnnotations;

namespace Buisness.Models;

public class ProductEntity
{
    [Key]
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string? CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
}
