using SejaHeroi.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SejaHeroi.Models.Animal
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        public Guid AnimalID { get; set; }
        public Guid UsuarioID { get; set; }
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
        public byte[] Foto { get; set; }

        public bool StatusVacina { get; set; }
    }
}