using Microsoft.AspNetCore.Mvc;

namespace meu_site_em_MVC.Controllers
{
    public class Contato : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
