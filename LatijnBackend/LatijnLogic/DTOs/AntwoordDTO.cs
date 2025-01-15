namespace LatijnLogic.DTOs
{
    public class AntwoordDTO
    {
        public int Id { get; set; }
        public required string Modus { get; set; }
        public required string Tempus { get; set; }
        public required string Genus { get; set; }
        public string? Persoon { get; set; }
        public string? Getal { get; set; }
    }
}
