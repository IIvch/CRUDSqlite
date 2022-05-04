using System.Collections.Generic;
using System.Linq;  

namespace CRUDSqlite
{
    public class DbItemsRepository : IDbItemsRepository
    {
        private readonly ItemsContext _itemsContext;

        public DbItemsRepository(ItemsContext itemsContext)
        {
            _itemsContext = itemsContext;
        }


        public Items GetItemsById(int id)
        /*
         * var obj = new ItemsRepository(context)
         * obj.GetItemsById(23242545466)
         */
        {
            return _itemsContext.Items.FirstOrDefault(e => e.Id == id);
        }

        public Items Create(int id, string name)
        {
            var result = _itemsContext.Add(new Items
            {
                Id = id,
                Name = name
            });
            _itemsContext.SaveChanges();
            return result.Entity;
        }

        public Items Update(Items items)
        {
            var result = _itemsContext.Update(items);
            _itemsContext.SaveChanges();
            return result.Entity;
        }

        // deleting items record
        public Items Delete(Items items)
        {
            var result = _itemsContext.Remove(items);
            _itemsContext.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<Items> GetAllItems
        {
            get { return _itemsContext.Items; }
        }
    }
}

