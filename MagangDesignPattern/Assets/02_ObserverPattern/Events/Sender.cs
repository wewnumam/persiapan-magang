using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer.Events
{
    public class Sender : MonoBehaviour
    {
        //public delegate void PlayerDied();
        //public static event PlayerDied OnPlayerDied; 
        
        public delegate float PlayerDied(Vector3 player, Vector3 target);
        public static event PlayerDied OnPlayerDied;

        private void Start()
        {
            Invoke("ExecuteEvent", 3f);
        }

        private void ExecuteEvent()
        {
            if (OnPlayerDied != null)
                OnPlayerDied(new Vector3(1, 1, 1), new Vector3(2, 2, 2));
        }
    }
}