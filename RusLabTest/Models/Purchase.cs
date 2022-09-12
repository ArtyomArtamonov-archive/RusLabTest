namespace RusLabTest.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int ClientId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
