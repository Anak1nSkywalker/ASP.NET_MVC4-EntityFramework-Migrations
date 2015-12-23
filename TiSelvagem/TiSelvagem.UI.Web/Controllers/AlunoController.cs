using System.Web.Mvc;
using TiSelvagem.Aplicacao;
using TiSelvagem.Dominio;

namespace TiSelvagem.UI.Web.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoAplicacao alunoAplicacao;

        public AlunoController()
        {
            alunoAplicacao = AlunoAplicacaoConstrutor.AlunoAplicacaoADO();
        }

        public ActionResult Index()
        {
            var listaDeAlunos = alunoAplicacao.ListarTodos();
            return View(listaDeAlunos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                alunoAplicacao.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Edit(string id)
        {
            var aluno = alunoAplicacao.ListarPorId(id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                alunoAplicacao.Salvar(aluno);
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Details(string id)
        {
            var aluno = alunoAplicacao.ListarPorId(id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }

        public ActionResult Delete(string id)
        {
            var aluno = alunoAplicacao.ListarPorId(id);

            if (aluno == null)
                return HttpNotFound();

            return View(aluno);            
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(string id)
        {
            var aluno = alunoAplicacao.ListarPorId(id);
            alunoAplicacao.Excluir(aluno);
            return RedirectToAction("Index");                    
        }
    }
}