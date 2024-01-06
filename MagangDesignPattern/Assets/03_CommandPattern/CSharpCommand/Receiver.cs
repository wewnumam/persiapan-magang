using System;
using UnityEngine;

namespace Command.CSharpCommand
{
    // The Receiver classes contain some important business logic. They know how
    // to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.
    class Receiver
    {
        public void DoSomething(string a)
        {
            Debug.Log($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Debug.Log($"Receiver: Also working on ({b}.)");
        }
    }
}