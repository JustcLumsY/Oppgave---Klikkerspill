namespace Oppgave___Klikkerspill
{
    public interface ICommand
    {
        void Run();
        char Character { get;  }
    }
}