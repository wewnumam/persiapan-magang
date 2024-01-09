using System;
using Unity.IO.LowLevel.Unsafe;

namespace State.UnityState
{
    [Serializable]
    public class StateMachine
    {
        public IState CurrentState { get; private set; }

        public WalkState walkState;
        public JumpState jumpState;
        public IdleState idleState;

        // event to notify other objects of the state change
        public event Action<IState> stateChanged;

        public StateMachine(PlayerController player)
        {
            this.walkState = new WalkState(player);
            this.jumpState = new JumpState(player);
            this.idleState = new IdleState(player);
        }

        public void Initialize(IState startingState)
        {
            CurrentState = startingState;
            startingState.Enter();

            // notify other objects that state has changed
            stateChanged?.Invoke(startingState);
        }

        public void TransitionTo(IState nextState)
        {
            CurrentState.Exit();
            CurrentState = nextState;
            nextState.Enter();
            // notify other objects that state has changed
            stateChanged?.Invoke(nextState);

        }

        public void Update()
        {
            if (CurrentState != null)
            {
                CurrentState.Update();
            }
        }
    }
}