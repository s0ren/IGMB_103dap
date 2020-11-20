using System;
using Xunit;
using IGMB_103dap;

namespace XUnitTestProject1
{
    public class InvesteringsTest
    {
        Investeringskonto konto;

        
        InvesteringsTest()
        {
            konto = new Investeringskonto(10000, -0.03);
        }

    

        [Fact]
        public void beregn()
        {
            konto.BeregnRente();
        }

    }
}
