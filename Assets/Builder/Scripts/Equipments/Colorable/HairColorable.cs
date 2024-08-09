using UnityEngine;

namespace Builder
{
    public class HairColorable : MonoBehaviour, IColorable
    {
        public MeshRenderer[] hairs;
        
        private static readonly int HashColor = Shader.PropertyToID("_Color");

        public void Paint(Color color)
        {
            foreach (MeshRenderer hair in hairs)
            {
                hair.material.SetColor(HashColor, color);
            }
        }
    }
}