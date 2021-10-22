using System.ComponentModel.DataAnnotations;

namespace SejaHeroi.Enums
{
  public enum StatusVacina
  {
    [Display(Name = "Completa", Description = "Completa")]
    Completa = 1,
    [Display(Name = "Com pendência", Description = "Com pendência")]
    Pendente = 0
  }
}