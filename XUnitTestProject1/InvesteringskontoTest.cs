using System;
using System.Collections.Generic;
using System.Text;
using IGMB_103dap;

namespace XUnitTestProject1
{
    class InvesteringskontoTest
    {
        Investeringskonto Konto;
        public InvesteringskontoTest()
        {
            Konto = new Investeringskonto(10000, 0.33);
            Konto.beregnRente();
        }
    }
}
