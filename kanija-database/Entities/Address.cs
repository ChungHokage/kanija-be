using kanija_database.Enum;

namespace kanija_database.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Ward { get; set; }
        public string? AddressDetail { get; set; }
        public AddressType? AddressType { get; set; }
        public bool IsDefault { get; set; }
    }
}