using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.Dominio;
using TiSelvagem.Aplicacao;

namespace UI.Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunoAplicacao = AlunoAplicacaoConstrutor.AlunoAplicacaoADO();

            Console.Write("Digite o nome do aluno");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome da mãe do aluno");
            string mae = Console.ReadLine();

            Console.Write("Digite a data de nascimento do aluno");
            string dataNascimento = Console.ReadLine();

            var aluno1 = new Aluno
            {
                Nome = nome,
                Mae = mae,
                DataNascimento = DateTime.Parse(dataNascimento)
            };

            alunoAplicacao.Salvar(aluno1);

            var dados = alunoAplicacao.ListarTodos();

            foreach (var aluno in dados)
            {
                Console.WriteLine("Id:{0}, Nome:{1}, Mae:{2}, DataNacimento:{3}",
                    aluno.AlunoId, aluno.Nome, aluno.Mae, aluno.DataNascimento);
            }

            Console.ReadLine();
        }
    }
}
