using System;
using Xunit;
using Bank;

namespace BankTest
{
    public class KasseKreditTest : IDisposable
    {
        KasseKredit k;
        double _kasseKredit = 5000;
        public KasseKreditTest()
        {

            this.k = new KasseKredit(0, _kasseKredit);
        }

        public void Dispose()
        {
            // dont know what to clean up
        }

        [Fact]
        public void TestConstructMed100kr()
        {
            k = new KasseKredit(100, _kasseKredit);
            Assert.Equal(100, k.saldo);
        }

        [Fact]
        public void TestConstructMed0kr()
        {
            //Konto k = new KasseKredit(0);
            //Assert.Equal(100, k.saldo);
            Assert.NotEqual(100, k.saldo);
        }

        [Fact]
        public void TestIndsæt100kr()
        {
            //Konto k = new KasseKredit(0);
            k.Indsæt(100);
            Assert.Equal(100, k.saldo);
        }

        [Fact]
        public void TestIndsæt0kr()
        {
            //Konto k = new Konto(0);
            k.Indsæt(0);
            Assert.Equal(0, k.saldo);
        }

        [Fact]
        public void TestIndsætMinus100kr()
        {
            //Konto k = new Konto(0);
            k.Indsæt(-100);
            Assert.Equal(-100, k.saldo);
        }

        [Fact]
        public void TestIndsætMegaMangeKr()
        {
            //Konto k = new Konto(0);
            k.Indsæt(Double.MaxValue);
            Assert.Equal(Double.MaxValue, k.saldo);
        }

        [Fact]
        public void TestIndsætMegaMangeKrPåKontoMed1kr()
        {
            k = new KasseKredit(1, _kasseKredit);
            //k.Indsæt(Double.MaxValue);
            //Assert.Equal(Double.MaxValue + 1, k.saldo);
            Assert.ThrowsAny<Exception>(() => k.Indsæt(Double.MaxValue));
        }

        [Fact]
        public void TestHæv10krPåKontoMed100()
        {
            k = new KasseKredit(100, _kasseKredit);
            k.Hæv(10);
            Assert.Equal(90, k.saldo);
        }

        [Fact]
        public void TestHæv100krPåKontoMed0()
        {
            //Konto k = new Konto(0);
            k.Hæv(100);
            Assert.Equal(-100, k.saldo);
        }

        [Fact]
        public void TestHæv100krPåKontoMed100()
        {
            k = new KasseKredit(100, _kasseKredit);
            k.Hæv(100);
            Assert.Equal(0, k.saldo);
        }
    }
}
