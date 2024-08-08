using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Singleton
{
    public abstract class GenericSingletonMultiThread<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        private static readonly object Obj = new();

        public static T Instance
        {
            get
            {
                lock (Obj)
                {
                    if (_instance != null)
                    {
                        return _instance;
                    }

                    _instance = FindObjectOfType<T>();

                    if (_instance != null)
                    {
                        return _instance;
                    }

                    var findGo = GameObject.Find(typeof(T).Name);

                    if (findGo != null)
                    {
                        _instance = findGo.AddComponent<T>();
                    }
                    else
                    {
                        _instance = CreateSingleton();
                    }
                }
                
                return _instance;
            }
        }

        private static T CreateSingleton()
        {
            var goName = typeof(T).Name;
            var go = new GameObject(goName);
            var component = go.AddComponent<T>();

            return component;
        }

        private void Awake()
        {
            Initialize();
        }

        protected abstract void Initialize();
        public abstract void Validate();
    }
}