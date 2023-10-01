using System.ComponentModel.DataAnnotations;

namespace backend.menu.Models;

public class Prato
{
    [Key]
    [Required]
    public int IdPrato { get; set; }
    [Required]
    public string DescPrato { get; set; }
    [Required]
    public decimal Preco { get; set; }
    public int IdCategoria { get; set; }
    public virtual Categoria Categoria { get; set; }
}