using Microsoft.AspNetCore.Mvc;

namespace Xplosive.Controllers
{
    public class NutritionController : Controller
    {
        public IActionResult Add()
        {
            return this.View();
        }
    }
}
