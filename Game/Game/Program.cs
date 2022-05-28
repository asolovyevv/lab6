using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Messange(string messange) => Console.WriteLine(messange);
        static void Main(string[] args)
        {
            Gamer g1 = new Gamer("Василий");
            g1.lucker += Messange;
            for (int i = 1; i <= 6; i++)
            {
                g1.SeansGame();
            }
        }
    }
}