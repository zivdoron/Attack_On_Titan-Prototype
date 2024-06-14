using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IAC.Gameplay;

namespace IAC.Gameplay
{
    [AddComponentMenu("IAC/Objects/Door Trigger")]
    public class DoorTrigger : MonoBehaviour
    {
        DoorMechanic doorController;

        void Start()
        {
            doorController = GetComponentInParent<DoorMechanic>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                doorController.NearDoor(true);
            }
        }

        
        private void OnTriggerExit(Collider other)
        {
             if(other.CompareTag("Player"))
            {
                doorController.NearDoor(false);
            }
        }
    }
}
