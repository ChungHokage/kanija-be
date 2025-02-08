namespace kanija_database.Entities
{
    public class Color
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? ColorCode { get; set; }
        public string? RGBCode { get; set; }
    }
}