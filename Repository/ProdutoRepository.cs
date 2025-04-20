using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDs.Data;
using ProjetoDs.Models;

namespace ProjetoDs.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ContatoContext contato_Context;

        public ProdutoRepository(ContatoContext contatoContext)
        {
            contato_Context = contatoContext;
        }
        public ProdutoModel adicionar(ProdutoModel produto)
        {
            contato_Context.Produtos.Add(produto);
            contato_Context.SaveChanges();
            return produto;
        }

        public List<ProdutoModel> listarProdutos()
        {
            return contato_Context.Produtos.ToList();
        }
        public ProdutoModel listarId(int Id)
        {
            return contato_Context.Produtos.FirstOrDefault(x => x.Id == Id);
        }
        public ProdutoModel editar(ProdutoModel produto)
        {
            ProdutoModel produtoDB = listarId(produto.Id);
            if (produtoDB == null) throw new Exception("Houve um Erro na atualização do produto!");
            produtoDB.Nome = produto.Nome;
            produtoDB.Preco = produto.Preco;
            produtoDB.Categoria = produto.Categoria;
            produtoDB.Quantidade = produto.Quantidade;
            produtoDB.Descricao = produto.Descricao;

            contato_Context.Produtos.Update(produtoDB);
            contato_Context.SaveChanges();
            return produtoDB;
        }

        public bool deletar(int id)
        {
            ProdutoModel produtoDB = listarId(id);

            if (produtoDB == null) throw new Exception("Houve um erro na atualização do produto!");
            contato_Context.Produtos.Remove(produtoDB);
            contato_Context.SaveChanges();
            return true;
        }

        public ProdutoModel ObterPorId(int Id)
        {
            return contato_Context.Produtos.FirstOrDefault(p => p.Id == Id);;
        }
    }
}