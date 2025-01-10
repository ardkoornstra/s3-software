

namespace LatijnLogic.Types
{
    public class Klas
    {
        public int Id { get; set; }
        public int DocentId { get; set; }

        public List<Toets> Toetsen { get; set; }
    }
}
