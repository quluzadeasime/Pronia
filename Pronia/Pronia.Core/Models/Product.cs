using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.Models;

public class Product:BaseEntity
{
    [Required]
    [StringLength(25)]
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<ProductPhoto> ProductPhotos { get; set; }
    public List<Tag> Tags { get; set; }
}
