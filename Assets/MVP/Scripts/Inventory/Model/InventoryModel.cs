using System;
using System.Collections.Generic;
using System.Linq;
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

            if (0 <= index && index < _inventory.Length)
            {
                int count = _inventory[index].Count;

                if (count == 1)
                {
                    _inventory[index] = null;    
                }
                else
                {
                    _inventory[index] = new SlotItem(item, count - 1);
                }
            }
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