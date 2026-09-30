using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ProjetoMVC.Models;

public partial class Paciente
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public string? Telefone { get; set; }

}
