using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using API.CalculaJuros.Controllers;

namespace Test
{
    public class CalculaJurosUnitTest
    {
        [Fact]
        public void Calcula_Juros_Baseado_Na_Taxa_De_Juros_E_Na_Quantidade_De_Meses()
        {
            double valorInicial = 100;
            int meses = 5;

            double valorFinal = Math.Truncate((valorInicial * Math.Pow((1.0 + 0.01), meses)) * 100) / 100;

            var calculaJuros = new CalculaJurosController();
            Assert.Equal(valorFinal, calculaJuros.Index(valorInicial, meses), 2);
        }
    }
}
