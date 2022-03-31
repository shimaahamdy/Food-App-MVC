using FoodApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodApp.Models
{
    
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the Price....")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Enter the MealName....")]
        public string Name { get; set; }
        public string Description { get; set; }
        public Category category { get; set; }
        public string Logo { get; set; }
        [ForeignKey("Restaurant")]
        public int RestId { get; set; } 
        public Restaurant Restaurant { get; set; }

    }
}
