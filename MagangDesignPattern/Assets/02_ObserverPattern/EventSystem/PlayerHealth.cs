using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Observer.EventSystem
{
    public class PlayerHealth : MonoBehaviour
    {
        private int health = 100;

        public GameEvent onPlayerHealthChange;

        public void DecreaseHealth()
        {
            health -= 10;
            onPlayerHealthChange.Raise(this, health);
        }
    }
}