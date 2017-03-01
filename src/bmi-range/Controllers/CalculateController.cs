using bmi_range.Models;
using Microsoft.AspNetCore.Mvc;

namespace bmi_range.Controllers
{
    [Route("api/[controller]")]
    public class CalculateController : Controller
    {
        public Response Post([FromBody]Request model)
        {
            if (model != null)
            {
                return new Models.Response(model.Bmi);
            }

            return null;
        }
    }
}