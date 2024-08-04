using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour, IBlocking
{
    bool blocking;
    public bool Blocking => blocking;
    [SerializeField] Collider collider;

    public void Block()
    {
        blocking = true;
        EnableShield();
    }

    public void StopBlocking()
    {
        blocking = false;
        DisableShield();
    }
    void EnableShield()
    {
        collider.enabled = true;
    }
    void DisableShield()
    {
        collider.enabled = false;
    }
}

public interface IBlocking
{
    bool Blocking {  get; }
    public void Block();
    public void StopBlocking();
}