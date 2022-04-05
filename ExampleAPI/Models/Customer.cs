namespace ExampleAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Pic { get; set; }
        public override bool Equals(object obj)
        {
            return this.Id.Equals(((Customer)obj).Id);
        }
    }
}
