using UnityEngine;

namespace Builder
{
    public class CharacterBuilder : MonoBehaviour
    {
        private CharacterHair _hair;
        private CharacterFace _face;
        private CharacterEyes _eyes;
        private CharacterBody _body;

        public CharacterBuilder SetHair(CharacterHair hair, Color color)
        {
            _hair = Instantiate(hair.gameObject).GetComponent<CharacterHair>();
            _hair.Paint(color);
            return this;
        }
        
        public CharacterBuilder SetFace(CharacterFace face, Color color)
        {
            _face = Instantiate(face.gameObject).GetComponent<CharacterFace>();
            _face.Paint(color);
            return this;
        }
        
        public CharacterBuilder SetEyes(CharacterEyes eyes, Color color)
        {
            _eyes = Instantiate(eyes.gameObject).GetComponent<CharacterEyes>();
            _eyes.Paint(color);
            return this;
        }
        
        public CharacterBuilder SetBody(CharacterBody body, Color color)
        {
            _body = Instantiate(body.gameObject).GetComponent<CharacterBody>();
            _body.Paint(color);
            return this;
        }

        public GameObject Build()
        {
            var go = new GameObject("character");
            go.transform.position = Vector3.zero;
            go.transform.rotation = Quaternion.identity;
            
            _hair.transform.SetParent(go.transform);
            _face.transform.SetParent(go.transform);
            _eyes.transform.SetParent(go.transform);
            _body.transform.SetParent(go.transform);
            
            _hair.transform.localPosition = Vector3.zero;
            _face.transform.localPosition = Vector3.zero;
            _eyes.transform.localPosition = Vector3.zero;
            _body.transform.localPosition = Vector3.zero;
            
            _hair.transform.localRotation = Quaternion.identity;
            _face.transform.localRotation = Quaternion.identity;
            _eyes.transform.localRotation = Quaternion.identity;
            _body.transform.localRotation = Quaternion.identity;
            
            _hair = null;
            _face = null;
            _eyes = null;
            _body = null;

            return go;
        }
    }
}