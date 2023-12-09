using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult getCities()
        {
            return new JsonResult(new List<object> {
                new {id= 1, name= "Bengaluru"},
                new {id= 2, name= "Mysore"},
                new {id= 3, name= "Mangalore"},
                new {id= 4, name= "Sakleshpur"}
            });
        }
    }
}
