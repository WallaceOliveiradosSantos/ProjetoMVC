using System;
using System.Collections.Generic;

namespace ProjetoMVC.Models;

public partial class Professor
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Especialidade { get; set; } = null!;

    public decimal Salario { get; set; }
}
