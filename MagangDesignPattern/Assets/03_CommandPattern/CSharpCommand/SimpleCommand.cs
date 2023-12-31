using UnityEngine;

namespace Command.CSharpCommand
{
    // Some commands can implement simple operations on their own.
    class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Debug.Log($"SimpleCommand: See, I can do simple things like printing ({_payload})");
        }
    }
}