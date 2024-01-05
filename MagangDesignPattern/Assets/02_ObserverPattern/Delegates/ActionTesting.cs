using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer.Delegates
{
	public class ActionTesting : MonoBehaviour
	{
		private Action testAction;
		private Action<int, float> testIntFloatAction;
		private Func<bool> testFunc;
		private Func<int, bool> testIntBoolFunc;

		private void Start()
		{
			testAction += MyTestActionFunction;
			testAction += MySecondTestActionFunction;
			testAction.Invoke();


			testIntFloatAction = (int i, float f) => Debug.Log("Test int float action!");
			testIntFloatAction.Invoke(1, 2.5f);

			testFunc = () => false;
			Debug.Log(testFunc.Invoke());
			
			testIntBoolFunc = (int i) => i < 5;
            Debug.Log(testIntBoolFunc.Invoke(1));
        }

		private void MyTestActionFunction()
		{
			Debug.Log("MyTestDelegateFunction");
		}

		private void MySecondTestActionFunction()
		{
			Debug.Log("MySecondTestDelegateFunction");
		}
	}
}