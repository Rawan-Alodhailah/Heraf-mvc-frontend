using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Products
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string claas { get; set; }
}