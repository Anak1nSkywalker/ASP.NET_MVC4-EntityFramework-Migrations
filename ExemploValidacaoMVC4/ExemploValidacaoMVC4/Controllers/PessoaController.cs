using ExemploValidacaoMVC4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacaoMVC4.Controllers
{
    public class PessoaController : Controller
    {        
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            /*
            if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório");
            }

            if (pessoa.Senha != pessoa.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas não conferem");
            }
            */

            if (ModelState.IsValid) 
            {
                return View("Resultado", pessoa);
 
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
                    
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
            {
                "Jonathan", 
                "Jose", 
                "Natascha"
            };

            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
