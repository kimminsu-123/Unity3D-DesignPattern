using System;
using System.Collections.Generic;
using System.Linq;
using DesignPattern.MVP.Interfaces;
using DesignPattern.MVP.Inventory;
using MVP.Model;
using MVP.Presenter;
using UnityEngine;

namespace MVP.View
{
    public class InventoryView : MonoBehaviour, IInventoryView
    {
        // for test
        [SerializeField] private Item[] itemPrefabs;
        
        [SerializeField] private InventorySlot[] slots;
        
        private IInventoryPresenter _presenter;

        private void Start()
        {
            _presenter = new InventoryPresenter(this);
        }

        private void Update()
        {
            // for test
            PickupItemTest();
            DropItemTest();
        }

        private void PickupItemTest()
        {
            // pickup Item 1
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _presenter.AddItem(itemPrefabs[0]);
            }
            
            // pickup Item 2
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _presenter.AddItem(itemPrefabs[1]);
            }
            
            // pickup Item 3
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _presenter.AddItem(itemPrefabs[2]);
            }
        }

        private void DropItemTest()
        {
            // pickup Item 1
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _presenter.RemoveItem(itemPrefabs[0]);
            }
            
            // pickup Item 2
            if (Input.GetKeyDown(KeyCode.W))
            {
                _presenter.RemoveItem(itemPrefabs[1]);
            }
            
            // pickup Item 3
            if (Input.GetKeyDown(KeyCode.E))
            {
                _presenter.RemoveItem(itemPrefabs[2]);
            }
        }

        public void RegisterOnClickSlot(Action<InventorySlot> callback)
        {
            foreach (InventorySlot slot in slots)
            {
                slot.RegisterOnClickSlot(callback);
            }
        }

        public void UpdateInventory(IEnumerable<SlotItem> items)
        {
            int index = 0;
            
            foreach (SlotItem item in items)
            {
                if (item == null)
                {
                    slots[index++].Clear();
                    continue;
                }
                
                slots[index++].SetItem(item);
            }
        }

        public void ClearInventory()
        {
            foreach (InventorySlot slot in slots)
            {
                slot.Clear();
            }
        }

        public void InputGrabItem(SlotItem item)
        {
            _presenter.RemoveItem(item.Item);
        }

        public void InputDropItem(InventorySlot slot, SlotItem item)
        {
            int index = slots.ToList().IndexOf(slot);
            _presenter.MoveItem(item, index);
        }
    }
}