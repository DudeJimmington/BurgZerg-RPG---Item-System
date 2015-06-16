using UnityEditor;
using UnityEngine;
using System.Collections;


namespace RPGModules.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor
    {

        //List all of the stored qualities in the database
        void ListView()
        {
            
            _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos, GUILayout.ExpandHeight(true));

            DisplayQualities();

            EditorGUILayout.EndScrollView();
        }


        void DisplayQualities()
        {
            for (int cnt = 0; cnt < qualityDatabase.Count ; cnt++)
            {
                GUILayout.BeginHorizontal("Box");

                //Sprite
                if (qualityDatabase.Get(cnt).icon)
                {
                    selectedTexture = qualityDatabase.Get(cnt).icon.texture;
                }
                else
                {
                    selectedTexture = null;
                }
                
                if(GUILayout.Button(selectedTexture, GUILayout.Width(SPRITE_BUTTON_SIZE), GUILayout.Height(SPRITE_BUTTON_SIZE)))
                {
                    int controllerID = EditorGUIUtility.GetControlID(FocusType.Passive);
                    EditorGUIUtility.ShowObjectPicker<Sprite>(null, true, null, controllerID);
                    selectedIndex = cnt;
                }

                string commandName = Event.current.commandName;
                if (commandName == "ObjectSelectorUpdated")
                {
                    if (selectedIndex != -1)
                    {
                        qualityDatabase.Get(selectedIndex).icon = (Sprite)EditorGUIUtility.GetObjectPickerObject();
                        //selectedIndex = -1;
                    }
                    Repaint();  
                }
                GUILayout.BeginVertical();
                //Name
                qualityDatabase.Get(cnt).Name = GUILayout.TextField(qualityDatabase.Get(cnt).Name);
                //Delete Button
                if (GUILayout.Button("X",GUILayout.Width(20),GUILayout.Height(20)))
                {
                    if(EditorUtility.DisplayDialog( "Delete Quality",
                                                    "Are You Sure You Want To Delete '"+ qualityDatabase.Get(cnt).Name +"' From The Database?",
                                                    "Delete",
                                                    "Cancel"))
                    {
                        qualityDatabase.Remove(cnt);
                    }
                }
                GUILayout.EndVertical();
                GUILayout.EndHorizontal();

            }
        }
    }
}
