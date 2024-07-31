using DesignPattern.MVP.Inventory;
using MVP.Model;
using UnityEngine;
using UnityEngine.UI;

namespace MVP
{
    public class InventoryInputHandler : MonoBehaviour
    {
        public Image grabbedItemIconImage;

        private RectTransform _grabbedItemIconImageRectTr;
        private SlotItem _grabbedItem;        
        private IInventoryView _inventoryView;
        
        private readonly float _halfWidth = Screen.width * 0.5f;
        private readonly float _halfHeight = Screen.height * 0.5f;

        private void Awake()
        {
            _inventoryView = GetComponent<IInventoryView>();
            _grabbedItemIconImageRectTr = grabbedItemIconImage.GetComponent<RectTransform>();
        }

        private void Start()
        {
            _inventoryView.RegisterOnClickSlot(OnClickSlot);
        }

        private void OnClickSlot(InventorySlot slot)
        {
            if (_grabbedItem == null)
            {
                GrabItem(slot.CurrentItem);
                return;
            }

            SlotItem slotItem = slot.CurrentItem;
            DropItem(slot);
            if (slot.CurrentItem != null)
            {
                GrabItem(slotItem);
            }
        }

        private void GrabItem(SlotItem item)
        {
            if (item == null)
            {
                return;
            }
            
            _grabbedItem = item;
            
            grabbedItemIconImage.sprite = _grabbedItem.Item.GetIcon();
            grabbedItemIconImage.gameObject.SetActive(true);
            
            _inventoryView.InputGrabItem(item);
        }

        private void DropItem(InventorySlot slot)
        {
            _inventoryView.InputDropItem(slot, _grabbedItem);
            
            _grabbedItem = null;
            grabbedItemIconImage.gameObject.SetActive(false);
        }

        private void Update()
        {
            if (_grabbedItem == null)
            {
                return;
            }
            
            Vector2 mousePos = Input.mousePosition;

            mousePos.x -= _halfWidth;
            mousePos.y -= _halfHeight;
            
            _grabbedItemIconImageRectTr.anchoredPosition = mousePos;
        }
    }
}