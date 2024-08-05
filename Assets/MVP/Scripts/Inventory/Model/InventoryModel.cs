using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;
using DesignPattern.MVP.Inventory;

namespace MVP.Model
{
    public class SlotItem
    {
        public IItem Item;
        public int Count;

        public SlotItem(IItem item, int count)
        {
            Item = item;
            Count = count;
        }
    }
    
    public class InventoryModel : IInventoryModel
    {
        private readonly SlotItem[] _inventory;
        
        public InventoryModel(int size)
        {
            _inventory = new SlotItem[size];
        }

        public IEnumerable<SlotItem> GetItems() => _inventory;
        public void RemoveItem(IItem item)
        {
            int index = GetItemIndex(item);
            _inventory[index] = null;    
        }

        public void AddItem(IItem item)
        {
            int find = GetItemIndex(item);

            if (find < 0)
            {
                int i = 0;
                for (; i < _inventory.Length; i++)
                {
                    var tuple = _inventory[i];

                    if (tuple == null)
                    {
                        break;
                    }
                }

                _inventory[i] = new SlotItem(item, 1);
            }
            else
            {
                int count = _inventory[find].Count;
                _inventory[find] = new SlotItem(item, count + 1);
            }            
        }

        public void MoveItem(SlotItem item, int index)
        {
            _inventory[index] = item;
        }

        private int GetItemIndex(IItem item)
        {
            bool found = false;
            int i = 0;
            for (; i < _inventory.Length; i++)
            {
                if (_inventory[i] == null)
                {
                    continue;
                }

                if (_inventory[i].Item.GetId().Equals(item.GetId()))
                {
                    found = true;
                    break;
                }
            }

            return found ? i : -1;
        }
    }
}