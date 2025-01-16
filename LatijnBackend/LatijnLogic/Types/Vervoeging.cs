namespace LatijnLogic.Types
{
    public class Vervoeging
    {
        public int Id { get; set; }
        public required int ToetsId { get; set; }
        public required bool IsCorrect { get; set; }
        
        public required string Vorm { get; set; }
        public required string Modus { get; set; }
        public required string Tempus { get; set; }
        public required string Genus { get; set; }
        public required string Persoon { get; set; }
        public required string Getal { get; set; }

        public required string Infinitivus { get; set; }
        public required string Praesens { get; set; }
        public required string Perfectum { get; set; }
        public required string Supinum { get; set; }
        public required int Conjugatie { get; set; }
        public required string Betekenis { get; set; }
    }
}
