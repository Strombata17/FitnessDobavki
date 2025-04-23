namespace Dobavki.Data
{
    public class Categorie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateRegister { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
