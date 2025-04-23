namespace Dobavki.Data
{
    public class TypeProduct
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateRegister { get; set; }

        public ICollection<Product> Products { get; set; }//1:m
    }
}
