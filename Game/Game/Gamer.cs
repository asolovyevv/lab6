using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Gamer
    {
        string name;
        Dice seans;
        public delegate void Rolls(string messange);
        public event Rolls lucker;
        public Gamer(string name)
        {
            this.name = name;
            seans = new Dice();
        }
        public void SeansGame()
        {
            int number = seans.Roll();
            if (number == 6)
                lucker?.Invoke("Бинго, выпало максимальное количество очков!");
            Console.WriteLine("Выпало количество очков {0} для игрока по имени {1}", number, name);
        }
    }
}
