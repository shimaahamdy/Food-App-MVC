using FoodApp.Models;
using System.Collections.Generic;

namespace FoodApp.Services
{
    public interface IRestaurantRepsitory
    {
        public List<Restaurant> GetAll();
        public Restaurant GetDetails(int id);
        public void Insert(Restaurant Rest);
        public void Update(int id, Restaurant Rest);
        public void Delete(int id);
    }
}
