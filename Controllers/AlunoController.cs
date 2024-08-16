using Microsoft.AspNetCore.Mvc;

namespace JovemProgramador.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
