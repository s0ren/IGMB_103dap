using System;
using Xunit;
using IGMB_103dap;

namespace BankenTest
{
    public class KontoTest : IDisposable
    {
        Konto k;
        public KontoTest()
        {
            this.k = new Konto(0);
        }

        public void Dispose()
        {
            // dont know what to clean up
        }

        [Fact]
        public void TestConstructMed100kr()
        {
            k = new Konto(100);
            Assert.Equal(100, k.Saldo);
        }

        [Fact]
        public void TestConstructMed0kr()
        {
            //Konto k = new Konto(0);
            //Assert.Equal(100, k.Saldo);
            Assert.NotEqual(100, k.Saldo);
        }

        [Fact]
        public void TestIndsaet100kr()
        {
            //Konto k = new Konto(0);
            k.Indsaet(100);
            Assert.Equal(100, k.Saldo);
        }

        [Fact]
        public void TestIndsaet0kr()
        {
            //Konto k = new Konto(0);
            k.Indsaet(0);
            Assert.Equal(0, k.Saldo);
        }

        [Fact]
        public void TestIndsaetMinus100kr()
        {
            //Konto k = new Konto(0);
            k.Indsaet(-100);
            Assert.Equal(0, k.Saldo);
        }

        [Fact]
        public void TestIndsaetMegaMangeKr()
        {
            //Konto k = new Konto(0);
            k.Indsaet(Double.MaxValue);
            Assert.Equal(Double.MaxValue, k.Saldo);
        }
        [Fact]
        public void TestIndsaetMegaMangeKrPÂKontoMed1kr()
        {
            k = new Konto(1);
            //k.Indsaet(Double.MaxValue);
            //Assert.Equal(Double.MaxValue + 1, k.Saldo);
            Assert.ThrowsAny<Exception>(() => k.Indsaet(Double.MaxValue));
        }

        [Fact]
        public void TestHaev10krPÂKontoMed100()
        {
            k = new Konto(100);
            k.Haev(10);
            Assert.Equal(90, k.Saldo);
        }

        [Fact]
        public void TestHaev100krPÂKontoMed0()
        {
            //Konto k = new Konto(0);
            k.Haev(100);
            Assert.NotEqual(-100, k.Saldo);
            Assert.Equal(0, k.Saldo);
        }

        [Fact]
        public void TestHaev100krPÂKontoMed100()
        {
            k = new Konto(100);
            k.Haev(100);
            Assert.Equal(0, k.Saldo);
        }
    }
}
