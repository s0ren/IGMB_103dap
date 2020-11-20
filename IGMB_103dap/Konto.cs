using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGMB_103dap
{
    public class Konto
    {
        /// <summary>
        /// Laver en Konto med et beløb indsat
        /// </summary>
        /// <param name="startSaldo">Det beløb der indsættes ved oprettelse</param>
        public Konto(double startSaldo)
        {
            saldo = startSaldo;
        }

        public double saldo { get; private set; }

        public void Indsæt(double beløb)
        {
            if (beløb <= 0)
            {
                throw new System.ArgumentException("Beløb må ikke være 0 eller mindre", "beløb");
            }
            this.saldo += beløb;
        }

        public void Hæv(double beløb)
        {
            if (saldo >= beløb)
            {
                saldo -= beløb;
            }
        }

    }
}
