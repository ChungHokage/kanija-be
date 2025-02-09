namespace kanija_database.Entities
{
    public class ProductInCategory
    {
        public Guid CategoryId { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Category? Category { get; set; }
    }
}