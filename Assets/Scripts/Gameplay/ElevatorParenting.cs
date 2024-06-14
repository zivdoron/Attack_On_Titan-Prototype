using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IAC.Gameplay
{
    [AddComponentMenu("IAC/Objects/Parent to Object")]
    public class ElevatorParenting : MonoBehaviour
    {
        public string playerTag = "Player";
        public Transform parentTarget;

        void Start()
        {
            if(!parentTarget)
            {
                parentTarget = this.transform.parent;
            }
        }

        void OnTriggerEnter (Collider other)
        {
            if(other.CompareTag(playerTag))
            {
                other.transform.SetParent(parentTarget);
            }
        }

        void OnTriggerExit (Collider other)
        {
            if(other.CompareTag(playerTag) && other.transform.parent == parentTarget)
            {
                other.transform.SetParent(null);
            }
        }

    }
}