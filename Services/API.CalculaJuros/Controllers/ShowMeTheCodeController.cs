using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [OpenApiTag("Show me the code")]
    public class ShowMeTheCodeController : Controller
    {
        /// <summary>
        /// Endpoint responsável por retornar a URL do repositório do projeto no GitHub.
        /// </summary>
        [HttpGet]
        public string Index()
        {
            return "https://github.com/fernadan/Project.Microservices";
        }
    }
}
