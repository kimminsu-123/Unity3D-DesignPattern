using UnityEngine;

namespace Builder
{
    public class BodyColorable : MonoBehaviour, IColorable
    {
        public MeshRenderer[] bodyMeshes;
        
        private static readonly int HashColor = Shader.PropertyToID("_Color");

        public void Paint(Color color)
        {
            foreach (MeshRenderer bodyMesh in bodyMeshes)
            {
                bodyMesh.material.SetColor(HashColor, color);
            }
        }
    }
}