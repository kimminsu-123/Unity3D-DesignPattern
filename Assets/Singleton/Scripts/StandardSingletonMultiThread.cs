using System;
using UnityEngine;

namespace Singleton
{
    public class StandardSingletonMultiThread : MonoBehaviour
    {
        private static StandardSingletonMultiThread _instance;
        private static readonly object Obj = new();

        public static  StandardSingletonMultiThread Instance
        {
            get
            {
                lock (Obj)
                {
                    if (_instance != null)
                    {
                        return _instance;
                    }

                    _instance = FindObjectOfType<StandardSingletonMultiThread>();

                    if (_instance != null)
                    {
                        return _instance;
                    }

                    var findGo = GameObject.Find(nameof(StandardSingletonMultiThread));

                    if (findGo != null)
                    {
                        _instance = findGo.AddComponent<StandardSingletonMultiThread>();
                    }
                    else
                    {
                        _instance = CreateSingleton();
                    }

                    return _instance;   
                }
            }
        }

        private static StandardSingletonMultiThread CreateSingleton()
        {
            var goName = nameof(StandardSingletonMultiThread);
            var go = new GameObject(goName);
            var component = go.AddComponent<StandardSingletonMultiThread>();

            return component;
        }

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            Debug.Log("Initializing standard singleton safe threads...");
        }
        
        public void Validate()
        {
            Debug.Log("Validation standard singleton safe thread");
        }
    }
}