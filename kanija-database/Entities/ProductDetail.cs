using kanija_database.Enum;

namespace kanija_database.Entities
{
    public class ProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProducId { get; set; }
        public Guid ColorId { get; set; }
        public Size Size { get; set; }
        public int SoldQuantity { get; set; }
        public int StockQuantity { get; set; }
        public Product? Product { get; set; }
        public Color? Color { get; set; }
    }
}