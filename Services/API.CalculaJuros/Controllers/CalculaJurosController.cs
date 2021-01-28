using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : Controller
    {
        /// <summary>
        /// Endpoint responsável por valor calculado de juros composto.
        /// </summary>
        /// <param name="valorinicial"></param> 
        /// <param name="meses"></param>
        [HttpGet]
        public double Index(double valorinicial, int meses)
        {
            return 105.10;
        }
    }
}
