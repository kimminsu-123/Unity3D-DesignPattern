using System;
using DesignPattern.MVP.Interfaces;
using MVP;
using MVP.Model;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DesignPattern.MVP.Inventory
{
    public class InventorySlot : MonoBehaviour, IPointerClickHandler
    {
        public UnityEvent<InventorySlot> onClicked;

        public SlotItem CurrentItem { get; private set; }
        
        [SerializeField] private Image itemImage;
        [SerializeField] private TMP_Text itemNameText;
        
        public void RegisterOnClickSlot(Action<InventorySlot> callback)
        {
            onClicked.AddListener(s => callback?.Invoke(s));
        }
        
        public void SetItem(SlotItem item)
        {
            if (item == null || item.Item == null)
            {
                Clear();
            }
            else
            {
                CurrentItem = item;
                itemNameText.text = $"{item.Item.GetName()} [{item.Count}]";
                itemImage.sprite = item.Item.GetIcon();
            }
        }

        public void Clear()
        {
            itemNameText.text = string.Empty;
            itemImage.sprite = null;
            CurrentItem = null;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            onClicked?.Invoke(this);
        }
    }
}