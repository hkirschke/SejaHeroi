using SejaHeroi.Data; 
using SejaHeroi.Extensions;
using System.Globalization;
using System.Web.Mvc;

namespace SejaHeroi.Controllers
{
    public class BaseController : Controller
    {
        protected readonly SejaHeroiContext _SejaHeroiContext = new SejaHeroiContext();
        protected readonly CultureInfo CultureInfo = CultureInfo.CreateSpecificCulture("pt-BR");

        /// <summary>
        /// {} realizado com sucesso!
        /// </summary>
        protected const string MensgemSucessoPadrao = "{0} com sucesso!";
        /// <summary>
        /// Erro ao efetuar \n{0}!
        /// </summary>
        protected const string MensgemErroPadrao = "Erro ao efetuar \n{0}!";
        /// <summary>
        /// Atenção! \n{0}
        /// </summary>
        protected const string MensgemAvisoPadrao = "Atenção! \n{0}";


        // GET: Base
        [AllowAnonymous]
        public virtual ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// {0} realizado com sucesso!
        /// </summary>
        public void AddNotificacaoSucesso(string acao)
        {
            this.AddNotification(string.Format(MensgemSucessoPadrao, acao), Extensions.NotificationType.SUCCESS);
        }
        /// <summary>
        /// Atenção! \n{0}
        /// </summary>
        public void AddNotificacaoAviso(string acao)
        {
            this.AddNotification(string.Format(MensgemAvisoPadrao, acao), Extensions.NotificationType.WARNING);
        }
        /// <summary>
        /// Erro ao efetuar \n{0}!
        /// </summary>
        public void AddNotificacaoErro(string acao)
        {
            this.AddNotification(string.Format(MensgemErroPadrao, acao), Extensions.NotificationType.ERROR);
        }

        public void AddNotificacaoInformacao(string acao)
        {
            this.AddNotification(string.Format("{0}", acao), Extensions.NotificationType.INFO);
        }
    }
}