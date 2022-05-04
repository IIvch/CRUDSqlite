using System.Collections.Generic;

namespace CRUDSqlite
{
    public interface IDbItemsRepository
    {
        public Items GetItemsById(int id);
        public Items Create(int id, string Name);
        public Items Update(Items items);
        public Items Delete(Items items);

        public IEnumerable<Items> GetAllItems { get; }
    }
}
