using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SejaHeroi.Models
{
    [Table("FichaCastracao")]
    public class FichaCastracao
    {
        [Key]
        public Guid CastracaoID { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Somente datas permitidas")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm:ss}", ApplyFormatInEditMode = true)] 
        public DateTime? DataEntrada { get; set; } 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddThh:mm}", ApplyFormatInEditMode = true)] 
        public DateTime? DataSaida { get; set; }
        public Guid UsuarioID { get; set; }
        public Guid AnimalID { get; set; }
        public Guid EquipeVeterinarioID { get; set; }
    }
}