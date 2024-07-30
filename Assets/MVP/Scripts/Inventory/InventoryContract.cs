using System;
using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;

namespace DesignPattern.MVP.Inventory
{
    public interface IInventoryView
    {
        public void UpdateInventory(IEnumerable<Tuple<IItem, int>> items);
        public void ClearInventory();
    }
    
    public interface IInventoryPresenter
    {
        public void DropItem(uint itemId);
        public void PickupItem(uint itemId);
        public void SwitchItems(int lIdx, int rIdx);
        public Tuple<IItem, int> GetItem(int index);
    }
    
    public interface IInventoryModel
    {
        public IEnumerable<Tuple<IItem, int>> GetItems();
        public void DropItem(uint itemId);
        public void PickupItem(uint itemId);
        public void SwitchItems(int lIdx, int rIdx);
        public Tuple<IItem, int> GetItem(int index);
    }
}