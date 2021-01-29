using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using API.TaxaJuros.Controllers;

namespace Test
{
    public class TaxaJurosUnitTest
    {
        [Fact]
        public void Carregar_Taxa_Juros_Atual()
        {
            var taxaJuros = new TaxaJurosController();

            Assert.Equal(0.01, taxaJuros.Index());
        }
    }
}
