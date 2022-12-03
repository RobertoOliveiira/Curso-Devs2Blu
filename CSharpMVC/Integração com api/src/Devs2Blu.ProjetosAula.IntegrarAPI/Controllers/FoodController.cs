using Devs2Blu.ProjetosAula.IntegrarAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.IntegrarAPI.Controllers
{
    public class FoodController : Controller
    {
        private readonly ILogger<FoodController> _logger;
        private readonly FoodApi Service = new FoodApi();
        public FoodController(ILogger<FoodController> logger)
        {
            _logger = logger;
        }
        [Route("search/{nameCard}")]
        public async Task<IActionResult> SearchFood(string nameCard)
        {
            var result= await Service.GetFoodByName(nameCard);
            return View(result);
        }

        
        public async Task<IActionResult> Index()
        {
            var result = await Service.GetFoods();
            return View(result);
        }
    }
}
