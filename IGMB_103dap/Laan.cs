namespace IGMB_103dap
{
    public class Laan : Konto
    {
        public double Gaeld { get; private set; }

        // Constructor til når man laver et nyt lån.
        public Laan(double beloeb) : base(beloeb) => Gaeld += beloeb;

        /// <summary>
        /// Udregning af afdrag til sin gæld.
        /// </summary>
        /// <param name="betaling"></param>
        /// <returns>Resten af sin gæld.</returns>
        public double Afdrag(double betaling)
        {
            double rest = 0;
            if (betaling > Gaeld) rest = betaling - Gaeld; 
            Gaeld -= betaling;
            return rest;
        }

        /// <summary>
        /// Tom override som ikke gør noget, da man ikke kan hæve fra et lån.
        /// </summary>
        /// <param name="beloeb"></param>
        public override void Haev(double beloeb) { }
    }
}
