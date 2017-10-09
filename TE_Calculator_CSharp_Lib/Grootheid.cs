// ReSharper disable MemberCanBePrivate.Global

namespace TE_Calculator_CSharp_Lib
{
    public class Grootheid
    {
        public Grootheid()
        {
        }

        public Grootheid(double? spanning, double? stroom, double? weerstand, double? vermogen)
        {
            Spanning = spanning ?? 0.0;
            Stroom = stroom ?? 0.0;
            Weerstand = weerstand ?? 0.0;
            Vermogen = vermogen ?? 0.0;
        }

        public double? Spanning { get; set; }
        public double? Stroom { get; set; }
        public double? Weerstand { get; set; }
        public double? Vermogen { get; set; }

        public double? CalculateSpanning() => Spanning = Weerstand != null ? Stroom * Weerstand : Vermogen / Stroom;

        public double? CalculateStroom() => Stroom = Weerstand != null ? Spanning / Weerstand : Vermogen / Spanning;

        public double? CalculateWeerstand() => Weerstand = Spanning / Stroom;

        public double? CalculateVermogen() => Vermogen = Spanning * Stroom;
    }
}