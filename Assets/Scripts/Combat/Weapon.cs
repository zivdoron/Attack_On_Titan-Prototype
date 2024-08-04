using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSproto.Combat
{
    public interface IWeapon
    {
        public DamageDealerBase DamageDealer { get; }
        public void EnableWeapon();
        public void DisableWeapon();

    }
    [RequireComponent(typeof(Collider))]
    public abstract class DamageDealerBase : MonoBehaviour
    {
        [SerializeField] protected Collider damageHitCollider;
        protected Collider DamageHitCollider { get; }
        [SerializeField] protected DamageData damageData;
        public DamageData DamageData { get; }
        public abstract void DealDamage(Health h);
        public abstract void EnableAttack();
        public abstract void DisableAttack();


    }
}