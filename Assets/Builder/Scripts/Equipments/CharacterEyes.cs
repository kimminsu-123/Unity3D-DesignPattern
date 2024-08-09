using UnityEngine;

namespace Builder
{
    public class CharacterEyes : MonoBehaviour
    {
        private IColorable _colorable;

        private void Awake()
        {
            _colorable = GetComponent<IColorable>();
        }
        
        public void Paint(Color color)
        {
            _colorable.Paint(color);
        }
    }
}