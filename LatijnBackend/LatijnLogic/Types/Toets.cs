

namespace LatijnLogic.Types
{
    public class Toets
    {
        public int Id { get; set; }
        public int AantalVragen { get; set; }
        public int AantalGoed { get; set; }
        public int SessionId { get; set; }
        public List<Vervoeging> Vervoegingen { get; set; }
    }
}
