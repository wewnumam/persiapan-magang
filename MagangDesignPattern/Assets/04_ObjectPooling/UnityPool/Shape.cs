using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPooling.UnityPool
{
    public class Shape : MonoBehaviour
    {
        private Action<Shape> _killAction;

        public void Init(Action<Shape> killAction)
        {
            _killAction = killAction;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.CompareTag("Ground"))
                _killAction(this);
        }
    }
}