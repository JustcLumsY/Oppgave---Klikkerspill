using System;

namespace Oppgave___Klikkerspill
{
    public class BuyUpgradeCommand : ICommand
    {

        private ClickerGame _game;
        public BuyUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            
           _game.Upgrade();
        }

        public char Character { get; } = 'K';
    }
}