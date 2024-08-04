using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSproto.Combat
{
    public class Avatar : MonoBehaviour
    {
        [SerializeField] WeaponSlot weaponSlot;
        public WeaponSlot WeaponSlot { get { return weaponSlot; } }
        [SerializeField] ShieldSlot shieldSlot;
        public ShieldSlot ShieldSlot { get { return shieldSlot; } }
    }
}