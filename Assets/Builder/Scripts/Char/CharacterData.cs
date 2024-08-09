using UnityEngine;

namespace Builder
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "Assets/CharacterData", order = 0)]
    public class CharacterData : ScriptableObject
    {
        [SerializeField] private CharacterHair hair;
        [SerializeField] private Color hairColor = Color.white;
        
        [SerializeField] private CharacterFace face;
        [SerializeField] private Color faceColor = Color.white;

        [SerializeField] private CharacterEyes eyes;
        [SerializeField] private Color eyesColor = Color.white;

        [SerializeField] private CharacterBody body;
        [SerializeField] private Color bodyColor = Color.white;

        public CharacterHair Hair => hair;
        public Color HairColor => hairColor;
        public CharacterFace Face => face;
        public Color FaceColor => faceColor;
        public CharacterEyes Eyes => eyes;
        public Color EyesColor => eyesColor;
        public CharacterBody Body => body;
        public Color BodyColor => bodyColor;
    }
}