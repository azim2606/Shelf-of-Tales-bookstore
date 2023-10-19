using System.ComponentModel.DataAnnotations;

namespace Shelf_of_Tales_bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Genre { get; set; } = string.Empty;
    }
}
