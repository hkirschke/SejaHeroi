using SejaHeroi.Data;
using SejaHeroi.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SejaHeroi.DataUtil
{
    public class SejaHeroiContextAnimalUtil : SejaHeroiContext
    {
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
