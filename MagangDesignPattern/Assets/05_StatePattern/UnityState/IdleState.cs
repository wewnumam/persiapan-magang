using UnityEngine;

namespace State.UnityState
{
    public class IdleState : IState
    {
        private PlayerController player;

        public IdleState(PlayerController player)
        {
            this.player = player;
        }

        public void Enter()
        {
            // code that runs when we first enter the state
            Debug.Log("Enter: Idle");
        }

        public void Update()
        {
            // per-frame logic, include condition to transition to a state
            Debug.Log("Update: Idle");
        }

        public void Exit()
        {
            // code that runs when we exit the state
            Debug.Log("Exit: Idle");
        }
    }
}