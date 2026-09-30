using System;
using System.Collections.Generic;

namespace ProjetoMVC.Models;

public partial class Consulta
{
    public int Codigo { get; set; }

    public DateTime DataConsulta { get; set; }

    public string Especialidade { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Observacao { get; set; }
}
