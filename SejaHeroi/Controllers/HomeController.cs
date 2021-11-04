using SejaHeroi.Models.Animal;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SejaHeroi.Controllers
{
  public class HomeController : BaseController
  {
    public override ActionResult Index()
    {
      List<AnimalViewModel> animaisDoacao = _SejaHeroiContextAnimalUtil.AnimaisDoacoes();
      return View(animaisDoacao);
    }
  }
}