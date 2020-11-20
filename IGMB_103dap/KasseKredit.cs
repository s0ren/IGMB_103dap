using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGMB_103dap
{
    public class KasseKredit : Konto
    {
        public double kasseKredit { get; private set; }

        public KasseKredit(double startSaldo, double kasseKreditStart) : base(startSaldo)
        {

            kasseKredit = 0 - kasseKreditStart;
        }

        public override void Hæv(double beløb)
        {
            if (beløb < kasseKredit)
            {
                return;
            }

            saldo -= beløb;
        }
    }
}
