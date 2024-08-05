using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    public class GraphicSettingMenu : MonoBehaviour, IMenu
    {
        [SerializeField] private Button hideButton;
        
        public void Initialize()
        {
            hideButton.onClick.AddListener(Hide);
            
            Hide();
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}