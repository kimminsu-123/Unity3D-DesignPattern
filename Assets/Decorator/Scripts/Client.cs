using UnityEngine;

namespace Decorator.Scripts
{
    public class Client : MonoBehaviour
    {
        public SkillGenerator generator;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                generator.GetSkill(1).Use();
            }
        
            if (Input.GetKeyDown(KeyCode.S))
            {
                generator.GetSkill(2).Use();
            }
        
            if (Input.GetKeyDown(KeyCode.D))
            {
                generator.GetSkill(3).Use();
            }
        }
    }
}