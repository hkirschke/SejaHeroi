using SejaHeroi.Data;
using SejaHeroi.Models.Animal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SejaHeroi.DataUtil
{
    public class SejaHeroiContextAnimalUtil : SejaHeroiContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        /// <summary>
        /// Retorna lista de AnimalViewModel, animais para doação 
        /// </summary>
        /// <returns></returns>
        public List<AnimalViewModel> AnimaisDoacoes()
        {
            List<AnimalViewModel> animaisDoacao = (from animalList in Animals.ToList()
                                                   where animalList.Situacao == Enums.Situacao.Disponivel
                                                   select new AnimalViewModel
                                                   {
                                                       AnimalID = animalList.AnimalID,
                                                       Nome = animalList.Nome,
                                                       Idade = animalList.Idade,
                                                       Situacao = animalList.Situacao,
                                                       RacaAnimal = animalList.RacaAnimal,
                                                       TamanhoAnimal = animalList.TamanhoAnimal,
                                                       UsuarioID = animalList.UsuarioID,
                                                       ByteFoto = animalList.Foto,
                                                       Resenha = animalList.Resenha
                                                   }).ToList();
            return animaisDoacao;
        }

        public List<AnimalViewModel> GetAnimaisUsuario(Guid usuarioID)
        {
            List<AnimalViewModel> animaisDoacao = (from animalList in Animals.ToList()
                                                   where animalList.UsuarioID == usuarioID
                                                   select new AnimalViewModel
                                                   {
                                                       AnimalID = animalList.AnimalID,
                                                       Nome = animalList.Nome,
                                                       Idade = animalList.Idade,
                                                       Situacao = animalList.Situacao,
                                                       RacaAnimal = animalList.RacaAnimal,
                                                       TamanhoAnimal = animalList.TamanhoAnimal,
                                                       UsuarioID = animalList.UsuarioID
                                                   }).ToList();
            return animaisDoacao;
        }

        public List<AnimalViewModel> AnimaisDesaparecidos()
        {
            List<AnimalViewModel> animaisDoacao = (from animalList in Animals.ToList()
                                                   where animalList.Situacao == Enums.Situacao.Desaparecido
                                                   select new AnimalViewModel
                                                   {
                                                       AnimalID = animalList.AnimalID,
                                                       Nome = animalList.Nome,
                                                       Idade = animalList.Idade,
                                                       Situacao = animalList.Situacao,
                                                       RacaAnimal = animalList.RacaAnimal,
                                                       TamanhoAnimal = animalList.TamanhoAnimal,
                                                       UsuarioID = animalList.UsuarioID,
                                                       ByteFoto = animalList.Foto,
                                                       Resenha = animalList.Resenha
                                                   }).ToList();
            return animaisDoacao;
        }
    }
}
