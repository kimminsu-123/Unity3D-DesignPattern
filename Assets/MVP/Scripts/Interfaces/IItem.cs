using UnityEngine;

namespace DesignPattern.MVP.Interfaces
{
    public interface IItem
    {
        public uint GetId();
        public string GetName();
        public Sprite GetIcon();
    }
}