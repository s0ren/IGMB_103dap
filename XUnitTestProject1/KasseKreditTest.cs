using System;
using Xunit;
using IGMB_103dap;

namespace BankenTest
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
        public void TestInds�t100kr()
        {
            //Konto k = new KasseKredit(0);
            k.Inds�t(100);
            Assert.Equal(100, k.saldo);
        }

        [Fact]
        public void TestInds�t0kr()
        {
            //Konto k = new Konto(0);
            k.Inds�t(0);
            Assert.Equal(0, k.saldo);
        }

        [Fact]
        public void TestInds�tMinus100kr()
        {
            //Konto k = new Konto(0);
            k.Inds�t(-100);
            Assert.Equal(-100, k.saldo);
        }

        [Fact]
        public void TestInds�tMegaMangeKr()
        {
            //Konto k = new Konto(0);
            k.Inds�t(Double.MaxValue);
            Assert.Equal(Double.MaxValue, k.saldo);
        }

        [Fact]
        public void TestInds�tMegaMangeKrP�KontoMed1kr()
        {
            k = new KasseKredit(1, _kasseKredit);
            //k.Inds�t(Double.MaxValue);
            //Assert.Equal(Double.MaxValue + 1, k.saldo);
            Assert.ThrowsAny<Exception>(() => k.Inds�t(Double.MaxValue));
        }

        [Fact]
        public void TestH�v10krP�KontoMed100()
        {
            k = new KasseKredit(100, _kasseKredit);
            k.H�v(10);
            Assert.Equal(90, k.saldo);
        }

        [Fact]
        public void TestH�v100krP�KontoMed0()
        {
            //Konto k = new Konto(0);
            k.H�v(100);
            Assert.Equal(-100, k.saldo);
        }

        [Fact]
        public void TestH�v100krP�KontoMed100()
        {
            k = new KasseKredit(100, _kasseKredit);
            k.H�v(100);
            Assert.Equal(0, k.saldo);
        }

        [Fact]
        public void TestH�vOverKasseKreditMed0()
        {
            //k = new KasseKredit(0, _kasseKredit);
            k.H�v(5200);
            Assert.NotEqual(-5200, k.saldo);
        }

        [Fact]
        public void TestH�vOverKasseKreditMed100()
        {
            k = new KasseKredit(100, _kasseKredit);
            k.H�v(5100);
            Assert.Equal(-5000, k.saldo);
        }
    }
}
