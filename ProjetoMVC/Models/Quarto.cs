using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMVC.Models;

[Table("Quarto")]
public partial class Quarto
{
    [Key]
    public int Codigo { get; set; }

    public int Numero { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal ValorDiaria { get; set; }

    public string Status { get; set; } = null!;
}