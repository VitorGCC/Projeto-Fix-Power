using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using ProjetoDs.Data;
using System.Linq;
using ProjetoDs.Repository;

namespace ProjetoDs.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;

public CarrinhoController(IProdutoRepository produtoRepository)
{
    this.produtoRepository = produtoRepository;
}

        public IActionResult Index()
        {
             var carrinho = ObterCarrinho();
            ViewBag.Carrinho = carrinho.Items;
            ViewBag.Total = carrinho.Total;
            return View();
        }
private Cart ObterCarrinho()
{
    var carrinho = HttpContext.Session.GetString("Carrinho");
    if (string.IsNullOrEmpty(carrinho))
    {
        return new Cart();
    }
    return JsonSerializer.Deserialize<Cart>(carrinho); // Deserializando corretamente como Cart
}
[HttpPost]
public IActionResult AdicionarAoCarrinho(int produtoId, int quantidade)
{
    // Lógica para adicionar o produto ao carrinho
    var produto = produtoRepository.ObterPorId(produtoId); // Recupera o produto do banco
    var itemCarrinho = new CarrinhoItemModel
    {
        Id = produto.Id,
        Nome = produto.Nome,
        Descricao = produto.Descricao,
        Preco = produto.Preco,
        Quantidade = produto.quantidade
    };

    var carrinho = ObterCarrinho();
    carrinho.AddItem(itemCarrinho);
    HttpContext.Session.SetString("Carrinho", JsonSerializer.Serialize(carrinho));

    return RedirectToAction("Index", "Carrinho");
}

    }
}
