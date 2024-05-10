using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.Core.Models;

public class Tag:BaseEntity
{
    [Required]
    [StringLength(25)]
    public string Name { get; set; } = null!;
    public List<Product> Products { get; set; }
}
