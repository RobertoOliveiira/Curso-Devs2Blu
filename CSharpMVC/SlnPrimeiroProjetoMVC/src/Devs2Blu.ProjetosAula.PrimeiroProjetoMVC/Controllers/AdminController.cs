using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            {
             new User { Id = 1, Name = "João Silva", Login = "joaos" }, 
             new User { Id = 2, Name = "Marcos Santos", Login = "marcoss" }, 
             new User { Id = 3, Name = "Carlos Lima", Login = "carlosl" }, 
             new User { Id = 4, Name = "Augusto Bonatti", Login = "augustob" }, 
             new User { Id = 5, Name = "Yuri Schmidt", Login = "yuris" }, 
             new User { Id = 6, Name = "Yung Lee Tsu", Login = "yungt" }, 
             new User { Id = 7, Name = "Ramon Lisboa", Login = "ramonl" } 
            };
            return View(users);
        }

        
        private readonly FoodAPIService Service = new FoodAPIService();

        [Route("indicadores")]
        [Route("numbers")]
        public async Task<IActionResult> Indicadores()
        {
            var result = await Service.GetFoods();
            return View(result);
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            //var result = Service.GetLista();
            return PartialView();
        }
    }
}
