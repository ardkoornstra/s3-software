namespace LatijnAPI.DTOs
{
    public class VraagDTO
    {
        public int Id { get; set; }
        public required string Vorm { get; set; }
        public required string Infinitivus { get; set; }
        public required string Praesens { get; set; }
        public required string Perfectum { get; set; }
        public required string Supinum { get; set; }
        public required string Betekenis { get; set; }
    }
}
