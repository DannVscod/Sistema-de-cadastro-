using Microsoft.AspNetCore.Mvc;

namespace Sistema_de_cadastro.Controllers
{
    public class Cadastro : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
