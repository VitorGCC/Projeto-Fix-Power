using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoDs.Models;

namespace ProjetoDs.Repository
{
    public interface IProdutoRepository
    {
        ProdutoModel adicionar(ProdutoModel produto);
        ProdutoModel listarId(int Id);
        List<ProdutoModel> listarProdutos();
        ProdutoModel editar(ProdutoModel produto);
        ProdutoModel ObterPorId(int Id);

        bool deletar(int id);
    }
}