using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ListaDeProduto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
