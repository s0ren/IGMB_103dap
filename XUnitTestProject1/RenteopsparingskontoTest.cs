using IGMB_103dap;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    public class RenteopsparingskontoTest
    {
        Renteopsparingskonto konto;
        public RenteopsparingskontoTest()
        {
            konto = new Renteopsparingskonto(10000, 2);
        }

        [Fact]
        public void TestForrentning()
        {
            var expected = 10200;
            var actual = konto.Forrentning();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ForrentningÆndrerIkkeSaldo()
        {
            var gammelSaldo = konto.Saldo;
            konto.Forrentning();

            Assert.Equal(gammelSaldo, konto.Saldo);
        }
    }
}
