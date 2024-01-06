using UnityEngine;

namespace Command.UnityCommand
{
    public class ChangeColorCommand : ICommand
    {
        Lightbulb _lightbulb;
        Color _previousColor;

        public ChangeColorCommand(Lightbulb lightbulb)
        {
            _lightbulb = lightbulb;
            _previousColor = _lightbulb.light.color;
        }

        public void Execute()
        {
            _previousColor = _lightbulb.light.color;
            _lightbulb.SetRandomLightColor();
        }

        public void Undo()
        {
            _lightbulb.light.color = _previousColor;
        }
    }
}