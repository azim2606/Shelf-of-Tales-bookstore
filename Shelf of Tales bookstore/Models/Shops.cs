using System.ComponentModel.DataAnnotations;

namespace Shelf_of_Tales_bookstore.Models
{
    public class Shops
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }      
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } 

        public string Price { get; set; }


    }
}
