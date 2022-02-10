namespace Catalog.Host.Models
{
    public class BoardGame
    {
        public string Title { get; set; } = default!;
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public string Description { get; set; } = default!;
    }
}
