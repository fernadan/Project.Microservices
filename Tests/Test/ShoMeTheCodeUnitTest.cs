using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using API.CalculaJuros.Controllers;

namespace Test
{
    public class ShoMeTheCodeUnitTest
    {
        [Fact]
        public void Recebe_Link_Github()
        {
            var showMeTheCode = new ShowMeTheCodeController();
            Assert.Contains("github", showMeTheCode.Index());
        }
    }
}
