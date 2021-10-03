using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SejaHeroi.Enums
{
    public enum PorteAnimal
    {
        Pequeno = 1,
        [Display(Name = "Médio")]
        [Description("Médio")]
        Medio = 2,
        Grande = 3,
    }
}