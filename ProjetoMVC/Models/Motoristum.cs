using System;
using System.Collections.Generic;

namespace ProjetoMVC.Models;

public partial class Motoristum
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Cnh { get; set; } = null!;

    public string? Telefone { get; set; }
}
