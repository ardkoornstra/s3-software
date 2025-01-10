namespace LatijnAPI.DTOs
{
    public class AntwoordDTO
    {
        public int Id { get; set; }
        public required string Modus { get; set; }
        public required string Tempus { get; set; }
        public required string Genus { get; set; }
        public required string Persoon { get; set; }
        public required string Getal { get; set; }
    }
}
