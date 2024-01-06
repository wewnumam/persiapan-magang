using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command.CSharpCommand
{
    public class Client : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}