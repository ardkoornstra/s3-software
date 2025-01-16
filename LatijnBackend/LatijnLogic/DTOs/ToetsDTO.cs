namespace LatijnLogic.DTOs
{
    public class ToetsDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AantalVragen { get; set; }
        public int AantalGoed { get; set; }
        public int SessionId { get; set; }
    }
}
