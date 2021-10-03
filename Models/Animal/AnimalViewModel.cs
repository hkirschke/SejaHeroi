using SejaHeroi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SejaHeroi.Models.Animal
{
    public class AnimalViewModel
    {
        public Guid AnimalID { get; set; }
        public Guid? UsuarioID { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public PorteAnimal TamanhoAnimal { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public Racas RacaAnimal { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public int Idade { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public Situacao Situacao { get; set; }
        public string Resenha { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase Imagem { get; set; }

        public byte[] ByteFoto { get; set; }

        public bool StatusVacina { get; set; }
    }
}