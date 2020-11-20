using System;
using System.Collections.Generic;
using System.Text;

namespace IGMB_103dap
{
    public class Investeringskonto : Konto
    {
        /// <summary>
        /// Er den fastsatte rentesats for investeringskontoen
        /// </summary>
        /// <param name="Rente">Den rentesats der indsættes i beregnRente metoden til beregning af renten af kontoens indhold</param>
        public double Rente { get; set; }
        public Investeringskonto(double startSaldo, double renteSats) : base(startSaldo)
        {
            Rente = renteSats;
        }
        /// <summary>
        /// Metoden til beregning af renten af investeringskontoens indhold
        /// </summary>
        /// <param name="startSaldo">Dette er vores saldo på kontoen som helst skal være positivt beløb</param>
        /// <param name="renteSats">Rentesatsen som bruges til i investeringskontoen (fks.) -0.01</param>
        public void beregnRente(double startSaldo, double renteSats)
        {
            double investeringsRente = startSaldo * renteSats;
        }
    }
}
