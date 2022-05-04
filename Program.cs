using System;
using System.Linq;

namespace CRUDSqlite
{
    class Program
    {
        static void Main(string[] args)

        // To Make CRUD operations uncomment method that u need | Для осуществления CRUD операций разкомментируйте нужный метод
        // 1. Create Item                                       | Создание
        // 2. Read Item by Id                                   | Чтение конкретного айтема по Id
        // 3. Update Item by Id                                 | Изменение по Id
        // 4. Delete Item by Id                                 | Удаление по Id
        // 5. Read All Items in DB                              | Отображение всех айтемов в БД
        // Method 1 set as default                              | Первый метод выбран как дефолтный
        {
            using var context = new ItemsContext();
            context.Database.EnsureCreated();

            var repo = new DbItemsRepository(context);

            // //////////////////////////////////////////////////////////////////////// 1. Create new Items record
            
             Console.WriteLine("Enter Items Information");
            
             Console.WriteLine("Id:");
             var id = Convert.ToInt32(Console.ReadLine());
            
             Console.WriteLine("Name:");
             var name = Console.ReadLine();
            
             var items = repo.Create(id, name);
            
             Console.WriteLine("Items Identified by Id "+ items.Id +" has been Added Successfully!");
            /////////////////////////////////
            //////////////////////////////////////////////////////////////////////////// 2. get Individual record
            //Console.WriteLine("Enter Id of the record to retrieve");
            //var idToRetrieve = Convert.ToInt32(Console.ReadLine());
            //var getItems = repo.GetItemsById(idToRetrieve);
            //Console.WriteLine($"Record details: {getItems.Name}");
            ///////////////////////
            //////////////////////////////////////////////////////////////////////////// 3. Update record
            //Console.WriteLine("Enter Id of the record to Update");
            //var idToUpdate = Convert.ToInt32(Console.ReadLine());
            //var itemsUpdate = repo.GetItemsById(idToUpdate);
            //if (itemsUpdate != null)
            //{
            //    Console.WriteLine("Add New Name");
            //    itemsUpdate.Name = Console.ReadLine(); ;
            //    repo.Update(itemsUpdate);
            //}
            ///////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////// 4. Delete a record
            //Console.WriteLine("Enter Id of the record to delete");
            //var idToDelete = Convert.ToInt32(Console.ReadLine());
            //var itemsDelete = repo.GetItemsById(idToDelete);
            //repo.Delete(itemsDelete);
            //////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////// 5. List all records
            //Console.WriteLine("All the items");
            //var items = repo.GetAllItems.ToList();
            //Console.WriteLine("    ID    |   Name    ");
            //Console.WriteLine("=====================================");
            //
            //foreach (var item in items)
            //{
            //    Console.WriteLine(item.Id + "      |     " + item.Name);
            //
            //}
            //
            //// var context = new ItemsContext("Data Source=ItemsDB.db");
        }
    }
}

