using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    /*
        GameMenu : IMenu 
            - MainMenuLeaf : IMenu
            - SettingMenuComposite : IMenu
                - AudioSettingMenuLeaf : IMenu
                - GraphicSettingMenuLeaf : IMenu
            - HelpSettingMenuLeaf : IMenu
        
        여기서 필요한 내용
        1. Initialize 
        2. Show
        3. Hide      
    */
    public class GameMenu : MonoBehaviour
    {
        [SerializeField] private Button showMainMenuButton;
        [SerializeField] private Button showSettingMenuButton;
        [SerializeField] private Button showHelpMenuButton;
        
        [SerializeField] private MainMenu mainMenu;
        [SerializeField] private SettingMenu settingMenu;
        [SerializeField] private AudioSettingMenu audioSettingSubMenu;        
        [SerializeField] private GraphicSettingMenu graphicSettingSubMenu;        
        [SerializeField] private HelpMenu helpMenu;

        private void Start()
        {
            mainMenu.Initialize();
            settingMenu.Initialize();
            audioSettingSubMenu.Initialize();
            graphicSettingSubMenu.Initialize();
            helpMenu.Initialize();
            
            showMainMenuButton.onClick.AddListener(mainMenu.Show);
            showSettingMenuButton.onClick.AddListener(settingMenu.Show);
            showHelpMenuButton.onClick.AddListener(helpMenu.Show);
            
            settingMenu.Add(audioSettingSubMenu);
            settingMenu.Add(graphicSettingSubMenu);
        }
    }
}