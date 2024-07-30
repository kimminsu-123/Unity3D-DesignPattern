using System;
using System.Collections.Generic;
using DesignPattern.MVP.Interfaces;
using DesignPattern.MVP.Inventory;
using MVP.Presenter;
using UnityEngine;

namespace MVP.View
{
    public class InventoryView : MonoBehaviour, IInventoryView
    {
        [SerializeField] private InventorySlot[] slots;
        
        private IInventoryPresenter _presenter;

        private void Start()
        {
            _presenter = new InventoryPresenter(this);
        }

        public void UpdateInventory(IEnumerable<Tuple<IItem, int>> items)
        {
            int index = 0;
            
            foreach (Tuple<IItem, int> item in items)
            {
                slots[index++].SetItem(item.Item1, item.Item2);

                if (index >= slots.Length)
                {
                    break;
                }
            }
        }

        public void ClearInventory()
        {
            foreach (InventorySlot slot in slots)
            {
                slot.Clear();
            }
        }
    }
}