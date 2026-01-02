using Microsoft.AspNetCore.Mvc;

namespace AttributeBasedRouting.Controllers
{
    [Route("[controller]")]
    public class TokenBasedController : Controller
    {
        [Route("[action]")]
        public int GetNumber()
        {
            return 100000;
        }

        [Route("[action]/{id}/{nm}")] //URL: http://localhost:48793/TokenBased/GetData/10/Sakshi
        public string GetData(int id, string nm)
        {
            return $"Id: {id}, Name:{nm}";
        }
    }
}
