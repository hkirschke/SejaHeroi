using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SejaHeroi.Enums
{
    public enum Situacao
    {
        Adotado = 1,
        [Display(Name = "Disponível", Description = "Disponível")]
        Disponivel = 2,
        [Display(Name = "Dono Próprio", Description = "Dono Próprio")]
        DonoProprio = 3,
        Desaparecido = 4
    }
}