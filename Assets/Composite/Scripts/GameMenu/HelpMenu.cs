using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    public class HelpMenu : MonoBehaviour, IMenu
    {
        [SerializeField, TextArea] private string helpMessage;
        [SerializeField] private TMP_Text helpText;
        [SerializeField] private Button hideButton;
        
        public void Initialize()
        {
            helpText.text = helpMessage;
            
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