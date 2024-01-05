using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Observer.Delegates
{
    public class ActionOnTimer : MonoBehaviour
    {
        private float timer;

        private Action timerCallback;

        public void SetTimer(float timer, Action timerCallback)
        {
            this.timer = timer;
            this.timerCallback = timerCallback;
        }

        private void Update()
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;

                if (IsTimerComplete())
                {
                    timerCallback();
                }
            }
        }

        public bool IsTimerComplete() => timer < 0;
    }
}
