using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TPSproto.Combat
{
    public class DamageDealer : DamageDealerBase
    {
        public override void DealDamage(Health h)
        {
            h.GetDamage(damageData);
        }

        public override void EnableAttack()
        {
            damageHitCollider.enabled = true;
        }
        public override void DisableAttack()
        {
            damageHitCollider.enabled = false;
        }


        private void OnTriggerEnter(Collider other)
        {
            other.gameObject.GetComponent<Health>()?.GetDamage(damageData);
        }
    }
}
