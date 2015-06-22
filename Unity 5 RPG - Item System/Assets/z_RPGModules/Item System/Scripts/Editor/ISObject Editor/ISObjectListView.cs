using UnityEngine;
using UnityEditor;
using System.Collections;


namespace RPGModules.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        Vector2 _scrollPos = Vector2.zero;
        int _ListViewWidth = 200;
        int _ListViewButtonWidth = 190;
        int _ListViewButtonHeight = 25;

        void ListView()
        {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_ListViewWidth)); //GUILayout.Height(_ListViewButtonHeight) - makes text unreadable when the name is too long

            for (int cnt = 0; cnt < database.Count; cnt++)
            {
                GUILayout.Button(database.Get(cnt).Name, "box", GUILayout.Width(_ListViewButtonWidth));
                
            }

            GUILayout.EndScrollView();
        }
    }
}