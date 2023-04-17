using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class CommandSet
    {
        public ICommand[] _commands;

        public CommandSet(ClickerGame clickerGame)
        {
            _commands = new ICommand[]
            {
                new ClickCommand(clickerGame),
                new ExitCommand(clickerGame),
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
