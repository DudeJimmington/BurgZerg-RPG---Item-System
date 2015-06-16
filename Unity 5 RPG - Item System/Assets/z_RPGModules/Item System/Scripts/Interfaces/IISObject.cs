using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem
{
    public interface IISObject
    {

        string Name { get; set; }           //name
        int Value { get; set; }             //Financial Value
        Sprite Icon { get; set; }           //Icon
        int Burden { get; set; }            //Burden
        ISQuality Quality { get; set; }     //Quality

        //THESE GOTO OTHER ITEM INTERFACES
        //equip
        //questItem flag
    }
}

