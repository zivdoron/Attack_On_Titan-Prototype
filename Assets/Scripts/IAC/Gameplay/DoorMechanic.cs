using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace IAC.Gameplay
{
    [AddComponentMenu("IAC/Objects/Door Lock")]
    public class DoorMechanic : MonoBehaviour
    {
        public UnityEvent unlockEvent;

        public KeyCode unlockInput = KeyCode.E;
        
        public int numberOfKeys = 1;

        private bool hasKeys = true;
        private bool isInvoked = false;
        private bool canUnlock = false;

        private int remainingKeys;


        void Start()
        {
            hasKeys = false;
            isInvoked = false;
            canUnlock = false;
            remainingKeys = numberOfKeys;
            
            if(remainingKeys == 0)
            {
                hasKeys = true;
            }
        }

         void Update()
        {
            if(!canUnlock)
            {
                return;
            }
            if(hasKeys && !isInvoked)
            {
                if(unlockInput == KeyCode.None)
                {
                     unlockEvent.Invoke();
                    isInvoked = true;
                }
                else if(Input.GetKeyDown(unlockInput))
                {
                    unlockEvent.Invoke();
                    isInvoked = true;
                }
            }
        }

        public void NearDoor(bool isNear)
        {
            canUnlock = isNear;
        }

        public void AcquiredKey ()
        {
            remainingKeys --;

            if(remainingKeys <= 0)
            {
                hasKeys = true;
            }
        }

        private void UnlockDoor()
        {
            unlockEvent.Invoke();
        }
    }
}
