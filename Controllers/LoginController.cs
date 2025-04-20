using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using ProjetoDs.Data;
using System.Linq;
using System;
using ProjetoDs.Repository;
using ProjetoDs.Helper;

namespace ProjetoDs.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository usuario_Repository;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepository usuarioRepository, ISessao sessao)
        {
            _sessao = sessao;
            usuario_Repository = usuarioRepository;
        }
        public IActionResult Index()
        {
            //Se o usuario estiver logado, redireciona para home
            if(_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Home");
            return View(); 
        }
        public IActionResult Sair(){
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel){
            try
            {
                if(ModelState.IsValid)
                {
                    UsuarioModel usuario = usuario_Repository.BuscarPorEmail(loginModel.Email);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            _sessao.CriarSessaoUsuario(usuario);
                        return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"A Senha do Usuario é Inválida. Por favor, tente novamente.";
                    }
                    TempData["MensagemErro"] = $"Usuario e/ou Senha inválidos. Por favor, tente novamente.";
                }
                return View("Index");
            }
            catch(Exception Error)
            {
                TempData["MensagemErro"] = $"Ops, Nao conseguimos realizar o login: {Error.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
