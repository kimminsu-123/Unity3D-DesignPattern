using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    public class SettingMenu : MonoBehaviour, IMenu, IMenuComposite
    {
        [SerializeField] private Button showAudioSettingMenu;
        [SerializeField] private Button showGraphicSettingMenu;
        [SerializeField] private Button hideButton;
        
        private Dictionary<Type, IMenu> _subMenus;

        public void Initialize()
        {
            _subMenus = new Dictionary<Type, IMenu>();
            
            showAudioSettingMenu.onClick.AddListener(ShowSubMenu<AudioSettingMenu>);
            showGraphicSettingMenu.onClick.AddListener(ShowSubMenu<GraphicSettingMenu>);
            hideButton.onClick.AddListener(Hide);
            
            Hide();
        }
        
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);

            foreach (IMenu menu in _subMenus.Values)
            {
                menu.Hide();
            }
        }

        public void ShowSubMenu<T>()
        {
            Type subMenuType = typeof(T);
            
            if (!_subMenus.ContainsKey(subMenuType))
            {
                throw new ArgumentException($"isn't contains key {subMenuType}");
            }
            
            _subMenus[subMenuType].Show();
        }

        public void Add(IMenu menu)
        {
            _subMenus.Add(menu.GetType(), menu);
        }

        public void Remove(IMenu menu)
        {
            _subMenus.Remove(menu.GetType());
        }
    }
}