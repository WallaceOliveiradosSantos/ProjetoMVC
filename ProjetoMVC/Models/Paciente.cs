using System;
using System.Collections.Generic;

namespace ProjetoMVC.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Cpf { get; set; }

    public DateOnly? DataNascimento { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }
}
