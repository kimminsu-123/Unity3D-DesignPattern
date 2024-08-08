using System;
using UnityEditorInternal;
using UnityEngine;

namespace Singleton
{
    public class StandardSingletonSingleThread : MonoBehaviour
    {
        private static StandardSingletonSingleThread _instance;

        public static StandardSingletonSingleThread Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                
                _instance = FindObjectOfType<StandardSingletonSingleThread>();

                if (_instance != null)
                {
                    return _instance;
                }

                var findGo = GameObject.Find(nameof(StandardSingletonSingleThread)); 

                if (findGo != null)
                {
                    _instance = findGo.AddComponent<StandardSingletonSingleThread>();
                }
                else
                {
                    _instance = CreateSingleton();
                }

                return _instance;
            }
        }

        private static StandardSingletonSingleThread CreateSingleton()
        {
            var goName = nameof(StandardSingletonSingleThread);
            var singleton = new GameObject(goName);
            var component = singleton.AddComponent<StandardSingletonSingleThread>();
            
            return component;
        }

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            Debug.Log("Initializing standard singleton unsafe thread...");
        }

        public void Validate()
        {
            Debug.Log("Validation standard singleton unsafe thread");
        }
    }
}
