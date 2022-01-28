using System;
using System.Runtime.InteropServices.ComTypes;

namespace Oppgave___Klikkerspill
{
    public class CommandSet
    {
        private ICommand[] _commands;

        public CommandSet(ClickerGame game)
        {
            _commands = new ICommand[]
            {
                new ExitGameCommand(),
                new GetPointsCommand(game),
                new BuyUpgradeCommand(game),
                new BuySuperUpgradeCommand(game),
            };
        }
        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }

        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
// Lag så en klasse for hver kommando i applikasjonen.
// Lag også en egen klasse CommandSet. Denne har en array med et objekt av hver kommando.
// Når brukeren taster et tegn, skal dette sendes til metoden RunCommand i CommandSet.
// Der slår den opp hvilken kommando som har den aktuelle bokstaven og kjører så Run på denne kommandoen.