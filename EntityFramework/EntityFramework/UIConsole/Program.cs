using Aplicacao;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaDeProdutoAplicacao appListaDeProduto = new ListaDeProdutoAplicacao();
            //ProdutoAplicacao appProduto = new ProdutoAplicacao();

            ////var lista01 = new ListaDeProduto();
            //var lista01 = appListaDeProduto.Listar().LastOrDefault();

            //lista01.Descricao = "Cesta Básica de Rico";
            ////lista01.Produtos = appProduto.Listar().Where(x => x.Categoria.Id == 2).ToList();
            //lista01.Produtos = appProduto.Listar().ToList();

            //appListaDeProduto.Excluir(lista01.Id);

            //var listas = appListaDeProduto.Listar();

            //foreach (var lista in listas)
            //{
            //    Console.WriteLine("{0} - {1}", lista.Id, lista.Descricao);
            //    foreach (var produto in lista.Produtos)
            //    {
            //        Console.WriteLine("     {0} - {1}", produto.Id, produto.Nome);
            //    }
            //}

            //Console.ReadKey();

            var appCategoria = new CategoriaAplicacao();

            //var objCategoria = new Categoria
            //{
            //    Descricao = "Enlatados"
            //};

            //appCategoria.Salvar(objCategoria);

            //var listaDeCategorias = appCategoria.Listar();

            //foreach (var listaDeCategoria in listaDeCategorias)
            //{
            //    Console.WriteLine("{0} - {1}", listaDeCategoria.Id, listaDeCategoria.Descricao);
            //}

            var appProduto = new ProdutoAplicacao();

            //var objProduto = new Produto
            //{
            //    Nome = "Sarddinha",
            //    Categoria = appCategoria.Listar().FirstOrDefault()
            //};

            //appProduto.Salvar(objProduto);

            //var listaDeProdutos = appProduto.Listar();

            //foreach (var listaDeProduto in listaDeProdutos)
            //{
            //    Console.WriteLine("{0} - {1}", listaDeProduto.Nome, listaDeProduto.Categoria.Descricao);
            //}

            var appListaDeProduto = new ListaDeProdutoAplicacao();

            var objListaDeProdutos = new ListaDeProduto
            {
                Descricao = "Lista de compras do John"
            };

            var produto01 = appProduto.Listar().FirstOrDefault();
            objListaDeProdutos.Produtos = new List<Produto>
            {
                produto01            
            };

            appListaDeProduto.Salvar(objListaDeProdutos);

            var listas = appListaDeProduto.Listar();

            foreach (var listaDeProduto in listas)
            {
                Console.WriteLine("{0}", listaDeProduto.Descricao);

                foreach (var produto in listaDeProduto.Produtos)
                {
                    Console.WriteLine("     {0} - {1}", produto.Nome, produto.Categoria.Descricao);                                        
                }
            }

            Console.ReadKey();
        }
    }
}
