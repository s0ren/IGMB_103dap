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
            Saldo = startSaldo;
        }

        // Laan branch: Ændret property navn fra saldo til Saldo.
        public double Saldo { get; private set; }

        // Laan branch: Ændret metode navn fra Indsæt til Indsaet
        // og parameter fra beløb til beloeb.
        public void Indsaet(double beloeb)
        {
            this.Saldo += beloeb;
        }

        // Laan branch: Ændret metode nav fra Hæv til Haev
        // og parameter fra beløb til beloeb.
        public virtual void Haev(double beloeb)
        {
            if (Saldo >= beloeb)
            {
                Saldo -= beloeb;
            }
        }

    }
}
