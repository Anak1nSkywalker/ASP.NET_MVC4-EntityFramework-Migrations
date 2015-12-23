using System.Collections.Generic;
using TiSelvagem.Dominio;
using TiSelvagem.Dominio.contrato;

namespace TiSelvagem.Aplicacao
{
    public class AlunoAplicacao
    {
        private readonly IRepositorio<Aluno> repositorio;

        public AlunoAplicacao(IRepositorio<Aluno> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Salvar(Aluno aluno)
        {
            repositorio.Salvar(aluno);
        }

        public void Excluir(Aluno aluno)
        {
            repositorio.Excluir(aluno);
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Aluno ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }

        //private List<Aluno> TransformaReaderEmListaAluno(SqlDataReader reader)
        //{ 
        //    var alunos = new List<Aluno>();
            
        //    while(reader.Read())
        //    {
        //        var tempObjeto = new Aluno() 
        //        {
        //            AlunoId = int.Parse(reader["AlunoId"].ToString()), 
        //            Nome = reader["Nome"].ToString(),
        //            Mae = reader["Mae"].ToString(), 
        //            DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
        //        };

        //        alunos.Add(tempObjeto);
        //    }

        //    reader.Close();
        //    return alunos;
        //}
    }
}
