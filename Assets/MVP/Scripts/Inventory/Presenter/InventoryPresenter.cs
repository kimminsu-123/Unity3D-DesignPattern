using System;
using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;
using DesignPattern.MVP.Inventory;
using MVP.Model;
using UnityEngine;

namespace MVP.Presenter
{
    public class InventoryPresenter : IInventoryPresenter
    {
        private readonly IInventoryView _inventoryView;
        private readonly IInventoryModel _inventoryModel;

        public InventoryPresenter(IInventoryView view)
        {
            // presenter 를 scriptable object 로 만들면 좋을 듯?
            _inventoryModel = new InventoryModel(25);
            
            _inventoryView = view;
            _inventoryView.ClearInventory();
        }

        public void RemoveItem(IItem item)
        {
            _inventoryModel.RemoveItem(item);
            _inventoryView.UpdateInventory(_inventoryModel.GetItems());
        }

        public void AddItem(IItem item)
        {
            _inventoryModel.AddItem(item);
            _inventoryView.UpdateInventory(_inventoryModel.GetItems());
        }

        public void MoveItem(SlotItem item, int index)
        {
            _inventoryModel.MoveItem(item, index);
            _inventoryView.UpdateInventory(_inventoryModel.GetItems());
        }
    }
}