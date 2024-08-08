using UnityEngine;

namespace Decorator.Scripts
{
    public class SkillLoader : MonoBehaviour
    {
        public SkillsData data;

        private void Awake()
        {
            Load();
        }

        private void Load()
        {
            TextAsset text = Resources.Load<TextAsset>("Skill");
            data = JsonUtility.FromJson<SkillsData>(text.text);
        }
    }
}