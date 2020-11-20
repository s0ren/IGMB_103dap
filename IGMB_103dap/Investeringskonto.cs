using System;
using System.Collections.Generic;
using System.Text;

namespace IGMB_103dap
{
    public class Investeringskonto : Konto
    {

        private double Rente { get; set; }
        public Investeringskonto(double startSaldo, double renteSats) : base(startSaldo)
        {
            Rente = renteSats;
        }

        public double beregnRente()
        {
            return this.saldo * this.Rente;
        }
    }
}
