using UnityEngine;

namespace Builder
{
    public class EyesColorable : MonoBehaviour, IColorable
    {
        public MeshRenderer[] eyes;
        
        private static readonly int HashColor = Shader.PropertyToID("_Color");

        public void Paint(Color color)
        {
            foreach (MeshRenderer eye in eyes)
            {
                eye.material.SetColor(HashColor, color);
            }
        }
    }
}