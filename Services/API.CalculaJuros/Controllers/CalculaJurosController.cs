using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.CalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [OpenApiTag("Calcula o Juros")]
    public class CalculaJurosController : Controller
    {
        /// <summary>
        /// Endpoint responsável por valor calculado de juros composto.
        /// </summary>
        /// <param name="valorinicial"></param> 
        /// <param name="meses"></param>
        [HttpGet]
        public async Task<string> Index(double valorinicial, int meses)
        {
            HttpClient _client = new HttpClient();
            var result = await _client.GetAsync("http://api.taxajuros:80/taxajuros");

            double valorFinal = Math.Truncate((valorinicial * Math.Pow((1.0 + Convert.ToDouble(result.Content.ReadAsStringAsync().Result)), meses)) * 100) / 100;

            return string.Format("{0:N2}", valorFinal); 
        }
    }
}
