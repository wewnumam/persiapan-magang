using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Observer.EventSystem
{
    public class GameEventListener : MonoBehaviour
    {
        public GameEvent gameEvent;

        public CustomGameEvent response;

        private void OnEnable()
        {
            gameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            gameEvent.UnRegisterListener(this);
        }

        public void OnEventRaised(Component sender, object data)
        {
            response.Invoke(sender, data);
        }
    }
}