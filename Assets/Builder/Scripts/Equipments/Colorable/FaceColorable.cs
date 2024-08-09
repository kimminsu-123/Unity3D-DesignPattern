using UnityEngine;

namespace Builder
{
    public class FaceColorable : MonoBehaviour, IColorable
    {
        public MeshRenderer face;
        
        private static readonly int HashColor = Shader.PropertyToID("_Color");

        public void Paint(Color color)
        {
            face.material.SetColor(HashColor, color);
        }
    }
}