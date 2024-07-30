using DesignPattern.MVP.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DesignPattern.MVP.Inventory
{
    // 입력 오퍼레이션 (인벤토리 관련) 스크립트에서 view를 들고 있고 거기서 입력처리하기
    // 아이템을 드래그앤 드롭으로 이동했다는 정보를 넘겨주면 그 정보를 presenter 통해서 model에 전달하고 model에서 변경 이후 다시 그리는 작업 실행
    /*
     * for (int i = 0; i < slots.length; i++){
     *  slots[i].SetItem(items);
     * }
     */
    
    public class InventorySlot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private Image itemImage;
        [SerializeField] private TMP_Text itemNameText;
        
        public void SetItem(IItem item, int count)
        {
            if (item == null)
            {
                Clear();
            }
            else
            {
                itemNameText.text = $"{item.GetName()} [{count}]";
                itemImage.sprite = item.GetIcon();
            }
        }

        public void Clear()
        {
            itemNameText.text = string.Empty;
            itemImage.sprite = null;    
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            
        }
    }
}