using System;
using UnityEngine;

namespace Singleton
{
    public class Client : MonoBehaviour
    {
        private void OnGUI()
        {
            if (GUI.Button(new Rect(0, 0, 300, 100), "Standard Singleton Single Thread"))
            {
                StandardSingletonSingleThread.Instance.Validate();
            }
            
            if (GUI.Button(new Rect(0, 200, 300, 100), "Generic Singleton Single Thread"))
            {
                SingleThreadGameManager.Instance.Validate();
            }
            
            if (GUI.Button(new Rect(0, 400, 300, 100), "Standard Singleton Multi Thread"))
            {
                StandardSingletonMultiThread.Instance.Validate();
            }
            
            if (GUI.Button(new Rect(0, 600, 300, 100), "Generic Singleton Multi Thread"))
            {
                MultiThreadGameManager.Instance.Validate();
            }
        }
    }
}