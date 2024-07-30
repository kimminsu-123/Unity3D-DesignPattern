using System;
using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;
using DesignPattern.MVP.Inventory;
using MVP.Model;

namespace MVP.Presenter
{
    public class InventoryPresenter : IInventoryPresenter
    {
        private readonly IInventoryView _inventoryView;
        private readonly IInventoryModel _inventoryModel;

        public InventoryPresenter(IInventoryView view)
        {
            _inventoryView = view;
            
            // presenter 를 scriptable object 로 만들면 좋을 듯?
            _inventoryModel = new InventoryModel(25);
            
            _inventoryView.UpdateInventory(null);
        }

        public void DropItem(uint itemId)
        {
            _inventoryModel.DropItem(itemId);

            IEnumerable<Tuple<IItem, int>> items = _inventoryModel.GetItems();
            _inventoryView.UpdateInventory(items);
        }

        public void PickupItem(uint itemId)
        {
            _inventoryModel.PickupItem(itemId);

            IEnumerable<Tuple<IItem, int>> items = _inventoryModel.GetItems();
            _inventoryView.UpdateInventory(items);
        }

        public void SwitchItems(int lIdx, int rIdx)
        {
            _inventoryModel.SwitchItems(lIdx, rIdx);
            
            IEnumerable<Tuple<IItem, int>> items = _inventoryModel.GetItems();
            _inventoryView.UpdateInventory(items);
        }

        public Tuple<IItem, int> GetItem(int index)
        {
            throw new NotImplementedException();
        }
    }
}