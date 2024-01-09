using UnityEngine;

namespace State.UnityState
{
    public class WalkState : IState
    {
        private PlayerController player;

        public WalkState(PlayerController player)
        {
            this.player = player;
        }

        public void Enter()
        {
            // code that runs when we first enter the state
            Debug.Log("Enter: Walk");
        }

        public void Update()
        {
            // per-frame logic, include condition to transition to a state
            Debug.Log("Update: Walk");
        }

        public void Exit()
        {
            // code that runs when we exit the state
            Debug.Log("Exit: Walk");
        }
    }
}