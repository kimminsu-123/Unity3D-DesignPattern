using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    public class MainMenu : MonoBehaviour, IMenu
    {
        [SerializeField] private TMP_Text gameStatusText;
        [SerializeField] private Button startGameButton;
        [SerializeField] private Button endGameButton;
        [SerializeField] private Button hideButton;
        
        public void Initialize()
        {
            startGameButton.onClick.AddListener(StartGame);
            endGameButton.onClick.AddListener(EndGame);
            hideButton.onClick.AddListener(Hide);
            
            Hide();
        }

        private void StartGame()
        {
            gameStatusText.text = "<color=red>Started Game!!</color>";
        }

        private void EndGame()
        {
            gameStatusText.text = "<color=blue>Ended Game!!</color>";
        }

        public void Show()
        {
            gameStatusText.text = "<color=black>Push Start Game!!</color>";
            
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}