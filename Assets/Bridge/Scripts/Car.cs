using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge
{
    public class Car : MonoBehaviour
    {
        private IColorable _colorable;

        private void Awake()
        {
            _colorable = GetComponent<IColorable>();
        }

        public void Paint()
        {
            _colorable.Paint();
        }
    }
}