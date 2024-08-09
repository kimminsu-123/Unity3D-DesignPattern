using System;
using UnityEngine;

namespace Builder
{
    public class Client : MonoBehaviour
    {
        public CharacterData data1;
        public CharacterData data2;
        public CharacterData data3;

        private GameObject _currentChar;
        private CharacterBuilder _builder;

        private void Awake()
        {
            _builder = FindObjectOfType<CharacterBuilder>(true);
        }

        private void OnGUI()
        {
            if (GUI.Button(new Rect(0, 0, 200, 100), "Create character with preset 1"))
            {
                if (_currentChar)
                {
                    Destroy(_currentChar);
                }
                _currentChar = _builder
                    .SetHair(data1.Hair, data1.HairColor)
                    .SetFace(data1.Face, data1.FaceColor)
                    .SetEyes(data1.Eyes, data1.EyesColor)
                    .SetBody(data1.Body, data1.BodyColor)
                    .Build();
            }
            
            if (GUI.Button(new Rect(0, 200, 200, 100), "Create character with preset 2"))
            {
                if (_currentChar)
                {
                    Destroy(_currentChar);
                }
                _currentChar = _builder
                    .SetHair(data2.Hair, data2.HairColor)
                    .SetFace(data2.Face, data2.FaceColor)
                    .SetEyes(data2.Eyes, data2.EyesColor)
                    .SetBody(data2.Body, data2.BodyColor)
                    .Build();
            }
            
            if (GUI.Button(new Rect(0, 400, 200, 100), "Create character with preset 3"))
            {
                if (_currentChar)
                {
                    Destroy(_currentChar);
                }
                _currentChar = _builder
                    .SetHair(data3.Hair, data3.HairColor)
                    .SetFace(data3.Face, data3.FaceColor)
                    .SetEyes(data3.Eyes, data3.EyesColor)
                    .SetBody(data3.Body, data3.BodyColor)
                    .Build();
            }
        }
    }
}