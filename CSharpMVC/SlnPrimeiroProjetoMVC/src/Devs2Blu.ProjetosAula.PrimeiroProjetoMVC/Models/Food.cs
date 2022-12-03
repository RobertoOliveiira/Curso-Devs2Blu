namespace Devs2Blu.ProjetosAula.IntegrarAPI.Models
{
    public class Food
    {
        public List<ResultsFoods> Meals { get; set; }
    }
    public class ResultsFoods
    {
        public string strMeal { get; set; }
        public string strMealThumb { get; set; }
        public string idMeal { get; set; }
    }

}
