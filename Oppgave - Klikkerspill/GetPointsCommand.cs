using System;

namespace Oppgave___Klikkerspill
{
    public class GetPointsCommand : ICommand
    {
        private ClickerGame _game;

        public char Character { get; } = 'A' ;
        public GetPointsCommand(ClickerGame game)
        {
            _game = game;
        }
       
        public void Run()
        {
            _game.Click();
        }

     
    }
}