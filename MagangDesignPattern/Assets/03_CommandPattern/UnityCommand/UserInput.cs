using UnityEngine;

namespace Command.UnityCommand
{
    public class UserInput : MonoBehaviour
    {
        public Lightbulb _lightbulb;
        private LightApp _lightApp;

        private void Start()
        {
            _lightApp = new LightApp();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ICommand togglePowerCommand = new TogglePowerCommand(_lightbulb);
                _lightApp.AddCommand(togglePowerCommand);
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                ICommand changeColorCommand = new ChangeColorCommand(_lightbulb);
                _lightApp.AddCommand(changeColorCommand);
            }
            else if (Input.GetKeyDown(KeyCode.Z))
            {
                _lightApp.UndoCommand();
            }
        }
    }
}