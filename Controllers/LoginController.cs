using SejaHeroi.Enums;
using SejaHeroi.Extensions;
using SejaHeroi.Models;
using System.Linq;
using System.Web.Mvc;

namespace SejaHeroi.Controllers
{
    public class LoginController : BaseController
    {
        // POST: Login/Autenticar
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Autenticar(Usuario usuario)
        {
            var user = (from userlist in _SejaHeroiContext.Usuarios
                        where userlist.Login == usuario.Login && userlist.Senha == usuario.Senha
                        select new
                        {
                            userlist.UsuarioID,
                            userlist.Login,
                            userlist.PerfilUsuario,
                        }).ToList();
            var usuarioEncontrado = user.FirstOrDefault();
            if (usuarioEncontrado != null)
            {
                this.AddNotification($"Bem vindo Herói!", NotificationType.INFO);
                Session["Perfil"] = usuarioEncontrado.PerfilUsuario;
                Session["UsuarioID"] = usuarioEncontrado.UsuarioID;
                    return Redirect("/Home/index");
            }
            else
            {
                this.AddNotification("Login/senha Inválido", NotificationType.ERROR); 
            }
            return View("Index");
        }

        public override ActionResult Index()
        {
            Session["Perfil"] = PerfilUsuario.Adotante;
            Session["UsuarioID"] = "";
            return base.Index();
        }

    }
}
