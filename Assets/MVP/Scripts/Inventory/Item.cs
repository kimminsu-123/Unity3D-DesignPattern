using DesignPattern.MVP.Interfaces;
using UnityEngine;

namespace DesignPattern.MVP.Inventory
{
    public class Item : MonoBehaviour, IItem
    {
        [SerializeField] private uint itemId;
        [SerializeField] private string itemName;
        [SerializeField] private Sprite itemIcon;

        public uint GetId() => itemId;
        public string GetName() => itemName;
        public Sprite GetIcon() => itemIcon;
    }
}