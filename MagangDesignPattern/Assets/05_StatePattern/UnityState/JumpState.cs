using UnityEngine;

namespace State.UnityState
{
    public class JumpState : IState
    {
        private PlayerController player;

        public JumpState(PlayerController player)
        {
            this.player = player;
        }

        public void Enter()
        {
            // code that runs when we first enter the state
            Debug.Log("Enter: Jump");
        }

        public void Update()
        {
            // per-frame logic, include condition to transition to a state
            Debug.Log("Update: Jump");
        }

        public void Exit()
        {
            // code that runs when we exit the state
            Debug.Log("Exit: Jump");
        }
    }
}