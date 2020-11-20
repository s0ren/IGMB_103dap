﻿using System;
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
      
        /// <summary>
        /// En egenskab der indeholder den aktuelle saldo.
        /// Dvs. havd der til enhvertid står på kontoen.
        /// </summary>
        public double Saldo { get; protected set; }

        // Laan branch: Ændret metode navn fra Indsæt til Indsaet
        // og parameter fra beløb til beloeb.
      
        /// <summary>
        /// Indsætter et beløb og opdaterer saldo tilsvarende.
        /// Bør kun kunne indsætte postive beløb, større end nul.
        /// </summary>
        /// <param name="beløb">Postivt tal, større end nul</param>
        public void Indsaet(double beloeb)
        {
            if (beloeb <= 0)
            {
                throw new System.ArgumentException("Beløb må ikke være 0 eller mindre", "beløb");
            }
            this.Saldo += beloeb;
        }

        // Laan branch: Ændret metode nav fra Hæv til Haev
        // og parameter fra beløb til beloeb.
      
        /// <summary>
        /// Hæver et et beløb, og opdaterer saldo
        /// kan kun hæve positive beløb, større end nul
        /// </summary>
        /// <param name="beløb">positivt tal større end 0</param>
        public virtual void Haev(double beloeb)
        {
            if (Saldo >= beloeb)
            {
                Saldo -= beloeb;
            }
        }
    }
}
