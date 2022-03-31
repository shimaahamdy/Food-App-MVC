using FoodApp.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.Models
{
   
   
    
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the ResturantName....")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public Street street { get; set; }
        public Government government { get; set; }
        public City city { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string phoneNum { get; set; }
        public ICollection<Item> Items { get; set; }

    }
}
