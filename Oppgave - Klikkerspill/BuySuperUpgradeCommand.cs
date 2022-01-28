using System;

namespace Oppgave___Klikkerspill
{
    public class BuySuperUpgradeCommand : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = 'S';

        public BuySuperUpgradeCommand(ClickerGame game)
        {
            _game = game;
        }
     

        public void Run()
        {
            _game.SuperUpgrade();
        }
    }
}