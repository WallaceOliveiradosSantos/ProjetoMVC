using System;
using System.Collections.Generic;

namespace ProjetoMVC.Models;

public partial class Medico
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string Crm { get; set; } = null!;

    public string Especialidade { get; set; } = null!;

    public string? Telefone { get; set; }
}
