using UnityEditor;
using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem.Editor
{
    public partial class ISQualityDatabaseEditor : EditorWindow
    {
        ISQualityDatabase qualityDatabase;
        Texture2D selectedTexture;
        int selectedIndex = -1;
        Vector2 _scrollPos; //scroll position for the ListView


        const int SPRITE_BUTTON_SIZE = 46;
        const string DATABASE_NAME = @"RPGQualityDatabase.asset";
        const string DATABASE_PATH = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_PATH + "/" + DATABASE_NAME;



        [MenuItem("RPG/Database/Quality Editor %#w")]
        public static void Init()
        {
            ISQualityDatabaseEditor window = EditorWindow.GetWindow<ISQualityDatabaseEditor>();
            window.minSize = new Vector2(400, 300);
            window.title = "Quality DB";
            window.Show();
        }



        void OnEnable()
        {
            qualityDatabase = ScriptableObject.CreateInstance<ISQualityDatabase>();
            qualityDatabase = qualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_PATH, DATABASE_NAME);
        }



        void OnGUI()
        {
            if (qualityDatabase == null)
            {
                Debug.LogWarning("qualityDatabase not Loaded!");
                return;
            }

            ListView();

            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));
            BottomBar();
            GUILayout.EndHorizontal();
        }



        void BottomBar()
        {
            //Count
            GUILayout.Label("Total Qualities: " + qualityDatabase.Count);
            //AddButton
            if (GUILayout.Button("Add Quality"))
            {
                qualityDatabase.Add(new ISQuality());
            }
        }

    }
}
