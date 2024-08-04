using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSproto.Combat
{
    public class MeleeWeapon : MonoBehaviour, IWeapon
    {
        [SerializeField] DamageDealerBase damageDealer;
        DamageDealerBase IWeapon.DamageDealer { get => damageDealer; }

        public void EnableWeapon()
        {
            damageDealer.EnableAttack();
        }
        public void DisableWeapon()
        {
            damageDealer.DisableAttack();
        }

    }
}