using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Helper;
using ProjetoDs.Models;
using ProjetoDs.Repository;

namespace ProjetoDs.Controllers
{

    public class UsuarioController : Controller
    {
                private readonly IUsuarioRepository usuario_Repository;
                private readonly ISessao _sessao;
    public UsuarioController(IUsuarioRepository usuarioRepository){
        usuario_Repository = usuarioRepository;
    } 
        public IActionResult Index()
    {
        return View("Index");
    }
        public IActionResult Criar()
    {
        var usuario = new UsuarioModel();
        return View(usuario);
    }   
        
    public IActionResult Registro()
    {
        return View("Registro"); 
    }
        [HttpPost]
    public IActionResult Criar(UsuarioModel usuario){
        if(ModelState.IsValid){
        usuario_Repository.adicionar(usuario);
        return RedirectToAction("Index");
        }
        return View(usuario);
        
    }
    }
}