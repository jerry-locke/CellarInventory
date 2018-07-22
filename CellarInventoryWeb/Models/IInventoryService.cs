using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellarInventoryWeb.Models
{
    public interface IInventoryService
    {
        List<Inventory> GetAllItems();

        Inventory GetItem(string Id);

        void DeleteItem(string Id);

        string CreateItem(Inventory NewItem);

        void EditItem(string Id, Inventory EditedItem);
    }
}