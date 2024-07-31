using System;
using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;
using MVP;
using MVP.Model;

namespace DesignPattern.MVP.Inventory
{
    public interface IInventoryView
    {
        public void RegisterOnClickSlot(Action<InventorySlot> callback);
        public void UpdateInventory(IEnumerable<SlotItem> items);
        public void ClearInventory();

        public void InputGrabItem(SlotItem slot);
        public void InputDropItem(InventorySlot slot, SlotItem item);
    }
    
    public interface IInventoryPresenter
    {
        public void RemoveItem(IItem item);
        public void AddItem(IItem item);
        public void MoveItem(SlotItem item, int index);
    }
    
    public interface IInventoryModel
    {
        public void RemoveItem(IItem item);
        public void AddItem(IItem item);
        public void MoveItem(SlotItem item, int index);

        public IEnumerable<SlotItem> GetItems();
    }
}