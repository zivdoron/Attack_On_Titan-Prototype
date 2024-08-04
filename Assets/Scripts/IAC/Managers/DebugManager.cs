using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IAC.Managers
{
[AddComponentMenu("IAC/Managers/Position Debugger")]
    public class DebugManager : MonoBehaviour
    {

        public Transform playerObject;

        public Transform[] debugPositions;

        public KeyCode cyclePositions = KeyCode.BackQuote;
        private int currentPosition;



        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1) && debugPositions.Length > 0)
            {
                currentPosition = 0;
                playerObject.position = debugPositions[0].position;
                playerObject.rotation = debugPositions[0].rotation;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2) && debugPositions.Length > 1)
            {
                currentPosition = 1;
                playerObject.position = debugPositions[1].position;
                playerObject.rotation = debugPositions[1].rotation;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3) && debugPositions.Length > 2)
            {
                currentPosition = 2;
                playerObject.position = debugPositions[2].position;
                playerObject.rotation = debugPositions[2].rotation;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha4) && debugPositions.Length>3)
            {
                currentPosition = 3;
                playerObject.position = debugPositions[3].position;
                playerObject.rotation = debugPositions[3].rotation;
            }
            else if(Input.GetKeyDown(KeyCode.Alpha5) && debugPositions.Length > 4)
            {
                currentPosition = 4;
                playerObject.position = debugPositions[5].position;
                playerObject.rotation = debugPositions[5].rotation;
            }

            if(Input.GetKeyDown(cyclePositions))
            {
                if(debugPositions.Length <= 0)
                {
                    return;
                }
                
                currentPosition ++;
                if(currentPosition >= debugPositions.Length)
                {
                    currentPosition = 0;
                }

                playerObject.position = debugPositions[currentPosition].position;
                playerObject.rotation = debugPositions[currentPosition].rotation;

            }

            
        }
            
    }
}
