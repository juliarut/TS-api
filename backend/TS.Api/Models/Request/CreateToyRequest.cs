namespace ToySwap.Api.Models.Request
{
    public class CreateToyRequest
    {
        public string Name { get; set; }
        public string Condition { get; set; }
        public int MinAge { get; set; }
        public string Description { get; set; }
    }
}