using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SejaHeroi.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Key]
        public Guid UsuarioID { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Complemento { get; set; }


        public Endereco()
        {

        }

        public Endereco(Guid ID)
        {
            UsuarioID = ID;
            Bairro = "";
            Rua = "";
            CEP = "";
            Numero = 0;
            Telefone = "";
            Celular = "";
            Complemento = "";
        }
    }
}