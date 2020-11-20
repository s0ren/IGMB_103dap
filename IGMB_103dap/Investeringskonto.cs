using System;
using System.Collections.Generic;
using System.Text;

namespace IGMB_103dap
{
    public class Investeringskonto : Konto
    {
        public double Rente { get; set; }
        public Investeringskonto(double startSaldo, double renteSats) : base(startSaldo)
        {
            double rente = renteSats;
        }

        public void beregnRente(double startSaldo, double renteSats)
        {
            double investeringsRente = startSaldo * renteSats;
        }
    }
}
