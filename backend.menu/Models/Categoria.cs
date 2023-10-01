using System.ComponentModel.DataAnnotations;

namespace backend.menu.Models;

public class Categoria
{
    [Key]
    [Required]
    public int IdCategoria { get; set; }
    [Required]
    public string DescCategoria { get; set; }
    public virtual ICollection<Prato> Pratos { get; set; }
}