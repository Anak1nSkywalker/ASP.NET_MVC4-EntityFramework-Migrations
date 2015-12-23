using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.Dominio;
using TiSelvagem.Dominio.contrato;
using TiSelvagem.Repositorio;

namespace TiSelvagem.RepostorioADO
{
    public class AlunoRepositorioADO : IRepositorio<Aluno>
    {
        private Contexto contexto;

        private void Inserir(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " INSERT INTO ALUNO (nome, mae, DataNascimento) ";
            strQuery += string.Format(" VALUES ('{0}', '{1}', '{2}') ",
                aluno.Nome, aluno.Mae, aluno.DataNascimento
                );

            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }
        }

        private void Alterar(Aluno aluno)
        {
            var strQuery = "";
            strQuery += " UPDATE ALUNO SET ";
            strQuery += string.Format(" Nome = '{0}', ", aluno.Nome);
            strQuery += string.Format(" Mae = '{0}', ", aluno.Mae);
            strQuery += string.Format(" dataNascimento = '{0}' ", aluno.DataNascimento);
            strQuery += string.Format(" WHERE alunoId = {0} ", aluno.AlunoId);

            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }
        }

        public void Salvar(Aluno aluno)
        {
            if (aluno.AlunoId > 0)
                Alterar(aluno);
            else
                Inserir(aluno);
        }

        public void Excluir(Aluno aluno)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format("DELETE FROM ALUNO WHERE AlunoId = {0}", aluno.AlunoId);
                contexto.ExecutarComando(strQuery);
            }
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "SELECT * FROM ALUNO";
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaAluno(retornoDataReader);
            }
        }

        public Aluno ListarPorId(string id)
        {
            using(contexto = new Contexto())
            {
                var strQuery = string.Format("SELECT * FROM ALUNO WHERE AlunoId = {0}", id);
                var retornoDataReader = contexto.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaAluno(retornoDataReader).FirstOrDefault();            
            }
        }

        private List<Aluno> TransformaReaderEmListaAluno(SqlDataReader reader)
        { 
            var alunos = new List<Aluno>();
            
            while(reader.Read())
            {
                var tempObjeto = new Aluno() 
                {
                    AlunoId = int.Parse(reader["AlunoId"].ToString()), 
                    Nome = reader["Nome"].ToString(),
                    Mae = reader["Mae"].ToString(), 
                    DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString())
                };

                alunos.Add(tempObjeto);
            }

            reader.Close();
            return alunos;
        }

    }
}
