using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem
{
    [System.Serializable] //Instead of "using System" up at the top
    public class ISQuality : IISQuality
    {
        [SerializeField]
        string _name;
        [SerializeField]
        Sprite _icon;



        public ISQuality()
        {
            _name = "";
            _icon = new Sprite();
        }
        public ISQuality(string name, Sprite icon)
        {
            _name = name;
            _icon = icon;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public Sprite icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
    }
}
//REMEMBER TO DELETE ALL EMPTY FUNCTIONS

