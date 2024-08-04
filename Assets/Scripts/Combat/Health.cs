using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TPSproto.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] int health;
        [SerializeField] int maxHealth;

        [SerializeField] UnityEvent OnCharacterDeath;
        TPSproto.Events.OnAction OnDeath = new TPSproto.Events.OnAction(delegate { });

        public void SubscribeOnZeroHealth(TPSproto.Events.OnAction evt)
        {
            if (OnDeath != null)
            {
                OnDeath += evt;
            }
        }

        public void GetDamage(DamageData damageData)
        {
            health -= damageData.Damage;
        }

        public void ResetHealth()
        {
            health = maxHealth;
        }
    }
    [System.Serializable]
    public struct DamageData
    {
        int damage;
        public int Damage { get { return damage; } }

        //can be progressed into a factory
        public DamageData(int dmg)
        {
            damage = dmg;
        }
    }
}
