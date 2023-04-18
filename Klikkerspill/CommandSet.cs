using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class CommandSet
    {
        private ICommand[] _commands;

        public CommandSet(ClickerGame clickerGame)
        {
            _commands = new ICommand[]
            {
                new ExitCommand(),
                new ClickCommand(clickerGame),
                new NormalUpgradeCommand(clickerGame),
                new SuperUpgradeCommand(clickerGame),
            };
        }

        public void RunCommand(char cmdFromUser)
        {
            foreach (var command in _commands)
            {
                if (command.Character == cmdFromUser)
                {
                    command.Run();
                    break;
                }
            }
        }
    }
}
