using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IAC.Managers;


namespace IAC.Gameplay
{
    [AddComponentMenu("IAC/Objects/Respawn Zone")]
    public class Respawner : MonoBehaviour
    {
        private TimeManager timeManager;
      
        public string playerTag = "Player";

        [Header ("Zone Settings")]
        public bool loseTime = false;
        public bool respawnPlayer = true;

        [Header ("Zone Values")]
        public float timeValue = -5f;

        public Transform respawnLocation;
        private Transform playerObject;
        private StarterAssets.FirstPersonController firstPersonController;
        private StarterAssets.ThirdPersonController thirdPersonController;
        private IEnumerator coroutine;


        private void Awake()
        {
            timeManager = FindObjectOfType<TimeManager>();
        }


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {
                playerObject = other.gameObject.transform;
                firstPersonController = playerObject.GetComponent<StarterAssets.FirstPersonController>();
                thirdPersonController = playerObject.GetComponent<StarterAssets.ThirdPersonController>();

                if (timeManager && loseTime)
                {
                    timeManager.AddTime(timeValue);
                }

                if(respawnPlayer)
                {
                    coroutine = ResetPlayerLocation(respawnLocation);
                    StartCoroutine(coroutine);
                }
            }
        }
    

         private IEnumerator ResetPlayerLocation(Transform newPosition)
        {
            if(firstPersonController != null)
            {
                firstPersonController.enabled = false;
                playerObject.rotation = newPosition.rotation;
            }
            else if(thirdPersonController != null)
            {
                thirdPersonController.enabled = false;
            }
            playerObject.position = newPosition.position;
            yield return new WaitForSeconds(0.2f);
            
            if(firstPersonController != null)
            {
                firstPersonController.enabled = true;
            }
            else if (thirdPersonController != null)
            {
                thirdPersonController.enabled = true;
            }
        }

        public void TeleportPlayer(Transform newPosition)
        {
            coroutine = ResetPlayerLocation(newPosition);
            StartCoroutine(coroutine);        
        }
    }
}
