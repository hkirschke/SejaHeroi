using SejaHeroi.Data;
using SejaHeroi.Models;
using SejaHeroi.Models.Animal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SejaHeroi.DataUtil
{
    public class SejaHeroiContextFichaUtil : SejaHeroiContext
    {
        public List<FichaCastracao> ValidaAgenda(DateTime? horaMarcacao, Guid equipeID)
        {
            List<FichaCastracao> ListAgendainvalida = new List<FichaCastracao>();
            if (horaMarcacao != null)
            {
                var newhoraMarcacao = Convert.ToDateTime(horaMarcacao);
                ListAgendainvalida = (from fichaList in FichaCastracaos.ToList()
                                      where (fichaList.DataEntrada?.Subtract(newhoraMarcacao))?.TotalMinutes < 20
                                      && fichaList.EquipeVeterinarioID == equipeID
                                      select new FichaCastracao
                                      {
                                          CastracaoID = fichaList.CastracaoID,
                                          DataEntrada = fichaList.DataEntrada
                                      }).ToList();
            }
            return ListAgendainvalida;
        }
    }
}
