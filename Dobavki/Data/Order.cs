namespace Dobavki.Data
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }//m:1

        public User Users { get; set; }//m:1

        public int ProductId { get; set; } //fk  m:1

        public Product Products { get; set; }//m:1

        public decimal Quantity { get; set; }

        public DateTime DateRegister { get; set; }

        
    }
}
