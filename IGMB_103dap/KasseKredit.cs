using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class KasseKredit : Konto
    {
        public double kasseKredit { get; private set; }

        public KasseKredit(double startSaldo, double kasseKreditStart) : base(startSaldo)
        {
            base.SætSaldo(startSaldo);
            this.kasseKredit = 0 - kasseKreditStart;
        }

        public override void Hæv(double beløb)
        {
            if (beløb < kasseKredit)
            {
                return;
            }

            SætSaldo(saldo - beløb);
        }
    }
}
