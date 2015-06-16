using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem
{
    public interface IISEquipmentSlot
    {
        string Name { get; set; }
        Sprite Icon { get; set; }
    }
}