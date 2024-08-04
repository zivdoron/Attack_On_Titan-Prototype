using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSproto.Combat
{
    public class WeaponSlot : MonoBehaviour
    {
        IWeapon weapon;
        public IWeapon Weapon { get => weapon; }
        [SerializeField] GameObject weaponGO;

        private void Awake()
        {
            if (Weapon == null)
            {
                if (!weaponGO.TryGetComponent(out weapon))
                    Debug.LogError("weapon is not existed as a weapon type");
            }
        }
        public void EquipWeapon(IWeapon weapon, GameObject weaponObject)
        {
            this.weapon = weapon;
            this.weaponGO = weaponObject;
        }
        public void ThrowWeapon()
        {
            if (weapon != null)
            {
                Destroy(weaponGO);
                weapon = null;
            }
        }
        public void GrabWeapon()
        {

        }
        public void DismantleWeapon()
        {

        }
    }
}