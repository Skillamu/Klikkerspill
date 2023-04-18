using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class ExitCommand : ICommand
    {
        public char Character { get; }

        public ExitCommand()
        {
            Character = 'X';
        }

        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
