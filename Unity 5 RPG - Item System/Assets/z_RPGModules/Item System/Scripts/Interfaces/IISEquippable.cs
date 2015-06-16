using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem
{
    public interface IISEquippable
    {
        ISEquipmentSlot EquipmentSlot { get; }
        bool Equip();
    }
}


