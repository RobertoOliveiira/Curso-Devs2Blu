using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("consulta")]
    public class ConsultaApiController : Controller
    {
        private readonly FoodAPIService Service = new FoodAPIService();
        public async Task<IActionResult> Index()
        {
            var result = await Service.GetFoods();

            return View(result);
        }

        [Route("pokemons")]
        public PartialViewResult Pokemons()
        {
            var result = Service.GetFoods();
            return PartialView();
        }
    }
}
