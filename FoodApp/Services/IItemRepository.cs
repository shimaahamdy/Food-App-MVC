using FoodApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodApp.Services
{
    public interface IItemRepository
    {
        public List<Item> GetAll();
        public Task<Item> GetDetails(int id);
        public void Insert(Item item);
        public void Update(int id, Item item);
        public void Delete(int id);
    }
}
