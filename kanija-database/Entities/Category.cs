namespace kanija_database.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public Guid? ParentCategory { get; set; } = null;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? SeoAlias { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastModified { get; set; }
        public ICollection<ProductInCategory>? ProductCategories { get; set; }
    }
}