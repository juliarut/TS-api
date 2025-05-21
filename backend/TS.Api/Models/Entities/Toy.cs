namespace ToySwap.Api.Models.Entities
{
    public class Toy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public int MinAge { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}