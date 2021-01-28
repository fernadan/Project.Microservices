using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.TaxaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : Controller
    {
        /// <summary>
        /// Endpoint responsável por retornar a taxa de juros atual.
        /// </summary>
        [HttpGet]
        public double Index()
        {
            return 0.01;
        }
    }
}
