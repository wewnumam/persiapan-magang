using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State.UnityState
{
    public interface IState
    {
        void Enter();
        void Update();
        void Exit();
    }
}