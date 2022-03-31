using FoodApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Services
{
    public class ItemRepoService : IItemRepository
    {
        public AppDbContext Context { get; set; }
        public ItemRepoService(AppDbContext context )
        {
            Context = context;
        }
    
        public List<Item> GetAll()
        {
           return Context.Items.Include(i=>i.Restaurant).ToList();
        }

        public async Task<Item> GetDetails(int id)
        {
            return await Context.Items.Include(e=>e.Restaurant).FirstOrDefaultAsync(i=>i.Id == id);
        }

        public void Insert(Item item)
        {
            Context.Items.Add(item);
            Context.SaveChanges();
        }

        public void Update(int id, Item item)
        {
            Context.Update(item);
            Context.SaveChanges();
        }
        public void Delete(int id)
        {
            Context.Remove(Context.Items.Find(id));
            Context.SaveChanges();
        }

    }
}
