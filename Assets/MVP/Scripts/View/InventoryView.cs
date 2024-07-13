using System;
using MVP.Scripts.Presenter;
using UnityEngine;

namespace MVP.Scripts.View
{
    public enum InventoryNotifyType
    {
        ItemSwitched,
        ItemDropped,
        ItemPicked,
    }
    
    public class InventoryView : MonoBehaviour, IView<InventoryNotifyType>
    {
        private InventoryPresenter _inventoryPresenter;
        
        private void Start()
        {
            _inventoryPresenter = new InventoryPresenter(this);
        }

        public void UpdateView(InventoryNotifyType type, params object[] args)
        {
            switch (type)
            {
                case InventoryNotifyType.ItemSwitched:
                    OnItemSwitched();
                    break;
                case InventoryNotifyType.ItemDropped:
                    OnItemDropped();
                    break;
                case InventoryNotifyType.ItemPicked:
                    OnItemPicked();
                    break;
            }
        }

        private void OnItemSwitched()
        {
            
        }
        
        private void OnItemDropped()
        {
            
        }
        
        private void OnItemPicked()
        {
            
        }
    }
}