using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.Dominio;
using TiSelvagem.Dominio.contrato;

namespace TiSelvagem.RepositorioEF
{
    public class AlunoRepositorioEF : IRepositorio<Aluno>
    {
        private readonly Contexto contexto;

        public AlunoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Aluno entidade)
        {
            if (entidade.AlunoId > 0)
            {
                var alunoAlterar = contexto.Alunos.First(x => x.AlunoId == entidade.AlunoId);
                alunoAlterar.Nome = entidade.Nome;
                alunoAlterar.Mae = entidade.Mae;
                alunoAlterar.DataNascimento = entidade.DataNascimento;
            }
            else
            {
                contexto.Alunos.Add(entidade);
            }

            contexto.SaveChanges();
        }

        public void Excluir(Aluno entidade)
        {
            var alunoExcluir = contexto.Alunos.First(x => x.AlunoId == entidade.AlunoId);
            contexto.Set<Aluno>().Remove(alunoExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            return contexto.Alunos.ToList();
        }

        public Aluno ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Alunos.First(x => x.AlunoId == idInt); 
        }
    }
}
