namespace AbstractFactory.Model
{
    public class Payment
    {
        public Guid id = Guid.NewGuid();
        public string? name;
        public decimal amount { get; set; }
        public string cardNumber { get; set; } = string.Empty;
    }
}
