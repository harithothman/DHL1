using System.ComponentModel.DataAnnotations;

namespace DHLOne.Models
{
    public class Item
    {
        [Key]
        public int itemId { get; set; }
        [Required]
        public string? itemName { get; set; }
        public string? itemDescription { get; set; }

    }
}