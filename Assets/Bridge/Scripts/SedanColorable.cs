using UnityEngine;

namespace Bridge
{
    public class SedanColorable : MonoBehaviour, IColorable
    {
        public MeshRenderer[] wheels;
        public MeshRenderer body;
        public MeshRenderer top;

        public Color wheelColor;
        public Color bodyColor;
        public Color topColor;
        
        private static readonly int HashColorName = Shader.PropertyToID("_Color");

        public void Paint()
        {
            foreach (MeshRenderer wheel in wheels)
            {
                wheel.material.SetColor(HashColorName, wheelColor);
            }
            body.material.SetColor(HashColorName, bodyColor);
            top.material.SetColor(HashColorName, topColor);
        }
    }
}