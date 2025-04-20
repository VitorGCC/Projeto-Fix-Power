using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Models;

namespace ProjetoDs.Controllers
{
    public class SenhaController : Controller
{
    [HttpGet]
    public IActionResult Senha()
    {
        return View("~/Views/Login/Senha.cshtml"); 
    }

    [HttpPost]
    public IActionResult Senha(ResetSenhaViewModel senhaViewModel)
    {
        if (ModelState.IsValid)
        {
        
            return RedirectToAction("Index", "Home");
        }

        return View(senhaViewModel);
    }
}

}