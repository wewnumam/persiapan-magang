
namespace Command.UnityCommand
{
    public class LightSwitch
    {
        ICommand _onCommand;

        public LightSwitch(ICommand onCommand)
        {
            _onCommand = onCommand;
        }

        public void TogglePower()
        {
            _onCommand.Execute();
        }
    }
}