using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class ExitCommand : ICommand
    {
        private ClickerGame _clickerGame;
        public char Character { get; }

        public ExitCommand(ClickerGame clickerGame)
        {
            _clickerGame = clickerGame;
            Character = 'X';
        }

        public void Run()
        {
            _clickerGame.Exit();
        }
    }
}
