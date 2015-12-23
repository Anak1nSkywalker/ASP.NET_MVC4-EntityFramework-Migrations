using PostGetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGetMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Jonathan de Oliveira Souza Araujo",
                Twitter = "@JonathanOliveira"
            };

            /*
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Twitter"] = pessoa.Twitter;
            */ 

            return View(pessoa);
        }

        [HttpPost]
        //public ActionResult Lista(int PessoaId, string Nome, string Twitter)
        //public ActionResult Lista(FormCollection form)
        public ActionResult Lista(Pessoa pessoa)
        {
            /*
            var pessoa = new Pessoa
            {
                
                PessoaId = PessoaId,
                Nome = Nome,
                Twitter = Twitter
                                
                PessoaId = Convert.ToInt32(form["PessoaId"]),
                Nome = form["Nome"],
                Twitter = form["Twitter"]
                 
            };
            */

            return View(pessoa);
        }
    }
}
