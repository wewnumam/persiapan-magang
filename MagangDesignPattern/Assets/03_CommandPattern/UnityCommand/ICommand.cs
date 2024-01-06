namespace Command.UnityCommand
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}