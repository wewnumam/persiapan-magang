using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer.Delegates
{
    public class DelegateTesting : MonoBehaviour
    {
        public delegate void TestDelegate();
        public TestDelegate testDelegateFunction;

        public delegate bool TestBoolDelegate(int i);
        public TestBoolDelegate testBoolDelegateFunction;

        private void Start()
        {
            testDelegateFunction += MyTestDelegateFunction;
            testDelegateFunction += MySecondTestDelegateFunction;
            testDelegateFunction();

            testDelegateFunction -= MySecondTestDelegateFunction;
            testDelegateFunction();

            // Delegate with param

            testBoolDelegateFunction += MyTestBoolDelegateFunction;
            Debug.Log(testBoolDelegateFunction(3)); // True
            Debug.Log(testBoolDelegateFunction(6)); // False

            // Anonymous method

            testDelegateFunction += delegate () { Debug.Log("Anonymouse method"); };
            testDelegateFunction += () => Debug.Log("Lambda expression");
            testDelegateFunction();
        }

        private void MyTestDelegateFunction()
        {
            Debug.Log("MyTestDelegateFunction");
        }

        private void MySecondTestDelegateFunction()
        {
            Debug.Log("MySecondTestDelegateFunction");
        }

        private bool MyTestBoolDelegateFunction(int i)
        {
            return i < 5;
        }
    }
}