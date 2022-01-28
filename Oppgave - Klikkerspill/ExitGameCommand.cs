using System;

namespace Oppgave___Klikkerspill
{
    public class ExitGameCommand : ICommand
    {
        public char Character { get; } = 'X';
        
        public void Run()
        {
            Environment.Exit(0);
        }

        
    }
}