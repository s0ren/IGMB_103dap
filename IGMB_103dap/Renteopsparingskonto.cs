using System;
using System.Collections.Generic;
using System.Text;

namespace IGMB_103dap
{
    public class Renteopsparingskonto : Konto
    {
        //Rentesats pr. forentning
        public double Rentesats { get; set; }
        public Renteopsparingskonto(double startSaldo, double rentesats) 
            : base(startSaldo)
        {
            Rentesats = rentesats;
        }
        /// <summary>
        /// Beregner ny saldo efter en forrentning
        /// </summary>
        /// <returns>Ny saldo</returns>
        public double Forrentning()
        {
            var nySaldo = saldo * (1 + Rentesats / 100);
            return nySaldo;
        }
    }
}
