using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer.Events
{
    public class Receiver : MonoBehaviour
    {
        private void OnEnable()
        {
            Sender.OnPlayerDied += PlayerDiedListener;
        }

        private void OnDisable()
        {
            Sender.OnPlayerDied -= PlayerDiedListener;
        }

        private void PlayerDiedListener()
        {
            Debug.Log("Player Died");
        }

        private float PlayerDiedListener(Vector3 player, Vector3 target)
        {
            Debug.Log(Vector3.Distance(target, player));
            return Vector3.Distance(target, player);
        }
    }
}