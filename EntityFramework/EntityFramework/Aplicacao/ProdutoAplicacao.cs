using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class ProdutoAplicacao
    {
        public DBProduto banco { get; set; }

        public ProdutoAplicacao()
        {
            banco = new DBProduto();
        }

        public void Salvar(Produto produto)
        {
            produto.Categoria = banco.Categorias.ToList().Where(x => x.Id == produto.Categoria.Id).FirstOrDefault();
            banco.Produtos.Add(produto);
            banco.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return banco.Produtos.Include(x => x.Categoria).ToList();
        }

        public void Alterar(Produto produto)
        {
            Produto produtoSalvar = banco.Produtos.Where(x => x.Id == produto.Id).First();
            produtoSalvar.Nome = produto.Nome;
            banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Produto produtoExcluir = banco.Produtos.Where(x => x.Id == Id).First();
            banco.Set<Produto>().Remove(produtoExcluir);
            banco.SaveChanges();
        }
    }
}
