using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGMB_103dap
{
    public class KasseKredit : Konto
    {
        /// <summary>
        /// Kundens kassekredit
        /// </summary>
        public double Kredit { get; private set; }

        /// <summary>
        /// Opretter en kasse kredit konto
        /// </summary>
        /// <param name="startSaldo">Det beløb der indsættes på en ny konto</param>
        /// <param name="kasseKreditStart">Det beløb kassekrediten skal være på.</param>
        public KasseKredit(double startSaldo, double kasseKreditStart) : base(startSaldo)
        {

            Kredit = 0 - kasseKreditStart;
        }

        /// <summary>
        /// Tillader kunden at hæve op til deres kassekredit.
        /// </summary>
        /// <param name="beloeb">beløb kunden ønsker at hæve</param>
        public override void Haev(double beloeb)
        {
            if (beloeb < Kredit)
            {
                return;
            }

            Saldo -= beloeb;
        }
    }
}
