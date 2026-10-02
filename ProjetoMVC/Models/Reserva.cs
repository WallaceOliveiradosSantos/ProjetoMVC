using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models;

public partial class Reserva
{
    [Key]
    public int Codigo { get; set; }

    public DateOnly DataEntrada { get; set; }

    public DateOnly DataSaida { get; set; }

    public int QuantidadeHospedes { get; set; }

    public decimal ValorTotal { get; set; }
}