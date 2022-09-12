namespace RusLabTest.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime RegDate { get; set; } = DateTime.UtcNow;
    }
}
