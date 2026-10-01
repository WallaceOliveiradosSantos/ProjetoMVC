namespace ProjetoMVC.Models;

public partial class Consulta
{
    public int IdConsulta { get; set; }
    public int IdPaciente { get; set; }
    public int IdMedico { get; set; }
    public DateTime DataConsulta { get; set; }
    public string? Descricao { get; set; }
    public string Status { get; set; } = null!;
    public decimal? Valor { get; set; }
}