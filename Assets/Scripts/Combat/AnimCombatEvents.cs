using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TPSproto.Combat;

public class AnimCombatEvents : MonoBehaviour
{
    [SerializeField] TPSproto.Combat.Avatar avatar;

    private void Awake()
    {
        if (avatar == null)
            TryGetComponent(out avatar);
    }
    public void EnableWeapon()
    {
        avatar?.WeaponSlot?.Weapon?.EnableWeapon();
    }
    public void DisableWeapon()
    {
        avatar?.WeaponSlot?.Weapon.DisableWeapon();
    }
    public void EnableShield()
    {
        avatar?.ShieldSlot?.Shield.Block();
    }
    public void DisableShield()
    {
        avatar?.ShieldSlot?.Shield.StopBlocking();

    }
}
