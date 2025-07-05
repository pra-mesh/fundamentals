using System.ComponentModel.DataAnnotations;

namespace DataLibrary.model;

public class Product
{
  [Required]
  public int Id { get; set; }

  [Required, StringLength(50)]
  public string Name { get; set; } = string.Empty;
  [Range(0.0, (double)decimal.MaxValue)]
  public decimal Price { get; set; } = 0;
  [Range(0, int.MaxValue)]
  public int Stock { get; set; }

  public string? PhotoFileName { get; set; } = string.Empty;
}