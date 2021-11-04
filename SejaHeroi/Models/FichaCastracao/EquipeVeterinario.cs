using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SejaHeroi.Models
{
    [Table("EquipeVeterinario")]
    public class EquipeVeterinario
    {
        [Key]
        public Guid EquipeVeterinarioID { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}