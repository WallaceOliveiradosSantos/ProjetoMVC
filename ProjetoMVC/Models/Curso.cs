using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models;

public partial class Curso
{
    [Key]
    [Display(Name = "Código")]
    public int Codigo { get; set; }

    [Required(ErrorMessage = "O nome do curso é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
    [Display(Name = "Nome do Curso")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "A carga horária é obrigatória.")]
    [Display(Name = "Carga Horária (horas)")]
    [Range(1, 1000, ErrorMessage = "A carga horária deve estar entre 1 e 1000 horas.")]
    public int CargaHoraria { get; set; }
}