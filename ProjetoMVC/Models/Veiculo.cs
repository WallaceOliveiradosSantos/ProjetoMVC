using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models;

public partial class Veiculo
{
    [Key]
    public int Codigo { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Ano { get; set; }

    public string Placa { get; set; } = null!;
}
