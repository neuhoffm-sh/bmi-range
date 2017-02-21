using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bmi_range.Models;
using Microsoft.AspNetCore.Mvc;

namespace bmi_range.Controllers
{
    [Route("api/[controller]")]
    public class CalculateController : Controller
    {
        [HttpPost]
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
