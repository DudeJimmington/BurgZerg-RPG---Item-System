using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        void TopTabBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            WeaponTab();
            ArmourTab();
            GUILayout.Button("Potions");
            AboutTab();

            GUILayout.EndHorizontal();
        }
        
        
        
        void WeaponTab()
        {
            GUILayout.Button("Weapons");
        }



        void ArmourTab()
        {
            GUILayout.Button("Armour");
        }



        void AboutTab()
        {
            GUILayout.Button("About");
        }
    }
}