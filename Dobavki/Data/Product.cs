namespace Dobavki.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TypeProductId { get; set; }

        public TypeProduct TypeProducts { get; set; }

        public int CategoriesId { get; set; }

        public Categorie Categories { get; set; }
        public decimal Quantity { get; set; }

        public string URLimage { get; set; }

        public string Apply {  get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime DateRegister { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}
