using UnityEngine;

namespace Bridge
{
    public class BusColorable : MonoBehaviour, IColorable
    {
        public MeshRenderer body;
        public MeshRenderer door;
        public MeshRenderer[] wheels;

        public Color bodyColor;
        public Color doorColor;
        public Color wheelColor;
        
        private static readonly int HashColorName = Shader.PropertyToID("_Color");
        
        public void Paint()
        {
            foreach (MeshRenderer wheel in wheels)
            {
                wheel.material.SetColor(HashColorName, wheelColor);
            }
            body.material.SetColor(HashColorName, bodyColor);
            door.material.SetColor(HashColorName, doorColor);
        }
    }
}