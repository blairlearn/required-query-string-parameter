using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace query_params.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DooHickeyController : ControllerBase
    {

        public class QueryParameters
        {
            [BindRequired]
            public string Required { get; set; }

            public string Optional { get; set; }
        }

        [HttpGet("WithParams")]
        public ActionResult<IEnumerable<string>> Get([FromQuery] QueryParameters parameters)
        {
            string optional = String.IsNullOrWhiteSpace(parameters.Optional) ? "not set" : parameters.Optional;

            return new string[] { $"Required: {parameters.Required}", $"Optional: {optional}" };
        }

    }
}
