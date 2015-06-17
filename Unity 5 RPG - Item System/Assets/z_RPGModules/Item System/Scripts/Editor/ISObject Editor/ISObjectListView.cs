using UnityEngine;
using System.Collections;


namespace RPGModules.ItemSystem.Editor
{
    public partial class ISObjectEditor
    {
        Vector2 _scrollPos = Vector2.zero;
        int _ListViewWidth = 200;

        void ListView()
        {
            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(_ListViewWidth));

            GUILayout.Label("List View");

            GUILayout.EndScrollView();
        }
    }
}