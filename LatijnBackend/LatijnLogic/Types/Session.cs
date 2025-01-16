namespace LatijnLogic.Types
{
    public class Session
    {
        public int Id { get; set; }
        //public required string Code { get; set; }
        public int DocentId { get; set; }

        public List<Toets> Toetsen { get; set; } = new List<Toets>();
    }
}
