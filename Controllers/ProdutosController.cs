using Microsoft.AspNetCore.Mvc;
using ProjetoDs.Models;
using ProjetoDs.Data; // Verifique se FixPowerContext está dentro deste namespace
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ProjetoDs.Repository;

namespace ProjetoDs.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ILogger<ProdutosController> _logger;



        // Ação para exibir o formulário de adição de produto
        public IActionResult Adicionar()
        {
            return View("Adicionar/Adicionar"); // Exibe a view de adicionar produto
        }

        // Ação para adicionar um novo produto
        // Ação para exibir as páginas de produtos (Rodas, Turbos, Escapamentos)
        public IActionResult Rodas()
        {
            return View("Rodas/Rodas");
        }

        public IActionResult CSPEC()
        {
            return View("Rodas/CSPEC");
        }

        public IActionResult Dcenti()
        {
            return View("Rodas/Dcenti");
        }

        public IActionResult GT7()
        {
            return View("Rodas/GT7");
        }
        public IActionResult Zeus()
        {
            return View("Rodas/Zeus");
        }

        public IActionResult Jdm()
        {
            return View("Rodas/EuroJDM");
        }
        public IActionResult Rotiform()
        {
            return View("Rodas/Rotiform");
        }
        public IActionResult Runner()
        {
            return View("Rodas/FuelRunner");
        }
        public IActionResult Burn()
        {
            return View("Rodas/FuelBurn");
        }

        public IActionResult Turbos()
        {
            return View("Turbos/Turbos");
        }

        public IActionResult Escapamentos()
        {
            return View("Escapamentos/Escapamentos");
        }

        public IActionResult Porsche991()
        {
            return View("Escapamentos/Porsche991.2");
        }

        public IActionResult AudiA3Sedan()
        {
            return View("Escapamentos/AudiA3Sedan");
        }

        public IActionResult Bmw320I()
        {
            return View("Escapamentos/Bmw320I");
        }

        public IActionResult AudiTT()
        {
            return View("Escapamentos/AudiTT");
        }

        public IActionResult AudiR8()
        {
            return View("Escapamentos/AudiR8");
        }

        public IActionResult GolfMK7()
        {
            return View("Escapamentos/GolfMK7");
        }

        public IActionResult Polo2020()
        {
            return View("Escapamentos/Polo2020");
        }

        public IActionResult JettaTsi()
        {
            return View("Escapamentos/JettaTsi");
        }
             public IActionResult Pistoes()
        {
            return View("Pistoes/Pistoes");
        }
             public IActionResult Ea111()
        {
            return View("Pistoes/Ea111");
        }
             public IActionResult Ap2_0Turbo()
        {
            return View("Pistoes/Ap2.0Turbo");
        }
             public IActionResult FiestaTurbo()
        {
            return View("Pistoes/FiestaTurbo");
        }
             public IActionResult Fiesta()
        {
            return View("Pistoes/Fiesta");
        }
             public IActionResult Marea()
        {
            return View("Pistoes/FiatMarea");
        }
             public IActionResult Etorq()
        {
            return View("Pistoes/FiatEtorq");
        }
             public IActionResult Ap1_8Turbo()
        {
            return View("Pistoes/Ap1.8Turbo");
        }
             public IActionResult Ap1_8()
        {
            return View("Pistoes/Ap1.8");
        }

        public IActionResult TA4502()
        {
            return View("Turbos/TA4502");
        }

        public IActionResult S400()
        {
            return View("Turbos/S400");
        }

        public IActionResult H1ESimples()
        {
            return View("Turbos/H1ESimples");
        }
        public IActionResult HX40wBUS()
        {
            return View("Turbos/HX40wBUS");
        }

        public IActionResult GarretGtx()
        {
            return View("Turbos/GarretGTX");
        }
        public IActionResult GarrettBuzu()
        {
            return View("Turbos/GarrettBuzu");
        }
        public IActionResult GarrettG45()
        {
            return View("Turbos/GarrettG45");
        }
        public IActionResult GarrettG42()
        {
            return View("Turbos/GarrettG42");
        }

        // Ação de erro
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
