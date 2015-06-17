using UnityEngine;
using System.Collections;



namespace RPGModules.ItemSystem
{
    public interface IISWeapon
    {
        int MinDamage { get; set; }
        int Attack();
    }
}
