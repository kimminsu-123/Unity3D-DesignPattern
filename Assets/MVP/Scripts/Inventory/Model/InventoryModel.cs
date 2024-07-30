using System;
using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;
using DesignPattern.MVP.Inventory;

namespace MVP.Model
{
    public class InventoryModel : IInventoryModel
    {
        private Tuple<IItem, int>[] _inventory;
        
        public InventoryModel(int size)
        {
            _inventory = new Tuple<IItem, int>[size];
        }

        public IEnumerable<Tuple<IItem, int>> GetItems() => _inventory;

        public void DropItem(uint itemId)
        {
            throw new System.NotImplementedException();
        }

        public void PickupItem(uint itemId)
        {
            throw new System.NotImplementedException();
        }

        public void SwitchItems(int lIdx, int rIdx)
        {
            throw new System.NotImplementedException();
        }

        public Tuple<IItem, int> GetItem(int index)
        {
            throw new NotImplementedException();
        }
    }
}