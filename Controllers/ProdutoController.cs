using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Models;
using ProjetoDs.Repository;

namespace ProjetoDs.Controllers;
public class ProdutoController : Controller
{
    private readonly IProdutoRepository produto_Repository;
    public ProdutoController(IProdutoRepository produtoRepository){
        produto_Repository = produtoRepository;
    } 
    public IActionResult Index()
    {
        List<ProdutoModel> produto = produto_Repository.listarProdutos();
        return View(produto);
    }
    public IActionResult Criar()
    {
        var produto = new ProdutoModel();
        return View(produto);
    }    
    [HttpPost]
    public IActionResult Criar(ProdutoModel produto){
        produto_Repository.adicionar(produto);
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Editar(ProdutoModel produto){
        produto_Repository.editar(produto);
        return RedirectToAction("Index");
    }
       public IActionResult Editar(int id)
    {
        ProdutoModel produto = produto_Repository.listarId(id);
        return View(produto);
    }

    public IActionResult VerificarDeletar(int id)
    {
        ProdutoModel  produto = produto_Repository.listarId(id);
        return View(produto);
    }
    public IActionResult Deletar(int id)
    {
        produto_Repository.deletar(id);
        return RedirectToAction("Index");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
