using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiSelvagem.RepostorioADO;
using TiSelvagem.RepositorioEF;

namespace TiSelvagem.Aplicacao
{
    public class AlunoAplicacaoConstrutor
    {
        public static AlunoAplicacao AlunoAplicacaoADO()
        {
            return new AlunoAplicacao(new AlunoRepositorioADO());            
        }

        public static AlunoAplicacao AlunoAplicacaoEF()
        {
            return new AlunoAplicacao(new AlunoRepositorioEF());
        }
    }
}
