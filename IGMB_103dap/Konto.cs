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

        /// <summary>
        /// En egenskab der indeholder den aktuelle saldo.
        /// Dvs. havd der til enhvertid står på kontoen.
        /// </summary>
        public double saldo { get; private set; }

        /// <summary>
        /// Indsætter et beløb og opdaterer saldo tilsvarende.
        /// Bør kun kunne indsætte postive beløb, større end nul.
        /// </summary>
        /// <param name="beløb">Postivt tal, større end nul</param>
        public void Indsæt(double beløb)
        {
            this.saldo += beløb;
        }

        /// <summary>
        /// Hæver et et beløb, og opdaterer daldo
        /// kan kun hæve positive beløb, større edn nul
        /// </summary>
        /// <param name="beløb">positivt tal større end 0</param>
        public void Hæv(double beløb)
        {
            if (saldo >= beløb)
            {
                saldo -= beløb;
            }
        }

    }
}
