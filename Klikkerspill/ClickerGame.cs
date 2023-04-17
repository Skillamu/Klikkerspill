using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klikkerspill
{
    internal class ClickerGame
    {
        private int _points = 0;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;

        public void Click()
            => Console.WriteLine("Click was invoked"); //_points += _pointsPerClick;

        public void Exit()
            => Console.WriteLine("Exit was invoked"); //Environment.Exit(0);

        public void NormalUpgrade()
        {
            Console.WriteLine("Normal Upgrade was invoked");
            /*_points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;*/
        }

        public void SuperUpgrade()
        {
            Console.WriteLine("Super Upgrade was invoked");
            /*_points -= 100;
            _pointsPerClickIncrease++;*/
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       koster 100 poeng\r\n - X = avslutt applikasjonen");
            Console.WriteLine($"Du har {_points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
        }
    }
}
