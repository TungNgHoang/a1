using Microsoft.AspNetCore.Mvc;
namespace a1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircleController : Controller
    {
        [HttpGet]
        public ActionResult Calculate(double radius)
        {
            var circumference = 2 * Math.PI * radius;
            var area = Math.PI * radius * radius;

            var result = new
            {
                Circumference = circumference,
                Area = area
            };

            return Json(result);
        }
    }
}
