using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Dominio;

namespace Aplicacao
{
    public class ListaDeProdutoAplicacao
    {
        public DBProduto banco { get; set; }

        public ListaDeProdutoAplicacao()
        {
            banco = new DBProduto();
        }

        public void Salvar(ListaDeProduto listaDeProduto)
        {
            listaDeProduto.Produtos =
                listaDeProduto.Produtos.Select(produto => banco.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();
            banco.ListaDeProdutos.Add(listaDeProduto);
            banco.SaveChanges();
        }

        public IEnumerable<ListaDeProduto> Listar()
        {
            return banco.ListaDeProdutos
                .Include(x => x.Produtos)
                .Include(x => x.Produtos.Select(c => c.Categoria))
                .ToList();
        }

        public void Alterar(ListaDeProduto listaDeProduto)
        {
            ListaDeProduto listaSalvar = banco.ListaDeProdutos.Where(x => x.Id == listaDeProduto.Id).First();
            listaSalvar.Produtos =
                listaDeProduto.Produtos.Select(produto => banco.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();
            listaSalvar.Descricao = listaDeProduto.Descricao;
            banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            ListaDeProduto listaExcluir = banco.ListaDeProdutos.Where(x => x.Id == Id).First();
            listaExcluir.Produtos = null;
            banco.Set<ListaDeProduto>().Remove(listaExcluir);
            banco.SaveChanges();
        }
    }
}
