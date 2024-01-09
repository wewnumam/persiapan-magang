using UnityEngine;

namespace State.UnityState
{
    public class PlayerController : MonoBehaviour
    {
        private StateMachine playerStateMachine;

        private void Awake()
        {
            playerStateMachine = new StateMachine(this);
        }

        private void Start()
        {
            playerStateMachine.Initialize(playerStateMachine.idleState);
        }

        private void Update()
        {
            if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0 && playerStateMachine.CurrentState != playerStateMachine.walkState)
                playerStateMachine.TransitionTo(playerStateMachine.walkState);
            else if (Input.GetKeyDown(KeyCode.Space) && playerStateMachine.CurrentState != playerStateMachine.jumpState)
                playerStateMachine.TransitionTo(playerStateMachine.jumpState);
            else if (Input.GetAxisRaw("Vertical") == 0 || Input.GetAxisRaw("Horizontal") == 0 && playerStateMachine.CurrentState != playerStateMachine.idleState)
                playerStateMachine.TransitionTo(playerStateMachine.idleState);

            playerStateMachine.Update();
        }
    }
}