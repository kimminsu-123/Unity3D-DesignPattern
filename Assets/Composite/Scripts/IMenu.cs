using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Composite
{
    public interface IMenu
    {
        public void Initialize();
        public void Show();
        public void Hide();
    }
}