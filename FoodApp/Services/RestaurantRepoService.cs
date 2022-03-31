using FoodApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FoodApp.Services
{
    public class RestaurantRepoService : IRestaurantRepsitory
    {
        public AppDbContext Context { get; set; }
        public RestaurantRepoService(AppDbContext context)
        {
            Context = context;
        }

        public List<Restaurant> GetAll()
        {
            return Context.Restaurants.ToList();
        }

        public Restaurant GetDetails(int id)
        {
            return Context.Restaurants.Find(id);
        }

        public void Insert(Restaurant Rest)
        {
            Context.Restaurants.Add(Rest);
            Context.SaveChanges();
        }

        public void Update(int id, Restaurant Rest)
        {
            Context.Update(Rest);
            Context.SaveChanges();
        }
        public void Delete(int id)
        {
            Context.Remove(Context.Restaurants.Find(id));
            Context.SaveChanges();
        }
    }
}
