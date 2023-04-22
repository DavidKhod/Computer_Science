using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjFirstMbt1;
namespace Q32
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tmove, Jmove;
            string winner = "The winner is:";
            Random move = new Random();
            TomAndJerry game = new TomAndJerry();
            while ((game.GetJerry() > 1 && game.GetJerry() < 51) && (game.GetTom() > 1 && game.GetTom() < 51) && game.GetJerry() != game.GetTom())
            {
                Tmove = move.Next(-5, 6);
                Jmove = move.Next(-5, 6);
                if (Tmove != 0 && Jmove != 0)
                {
                    game.SetTom(Tmove);
                    if (game.GetTom() == game.GetJerry() || (game.GetJerry() > 50 || game.GetJerry() < 1))
                    {
                        winner += " Tom";
                    }
                    game.SetJerry(Jmove);
                    if (game.GetTom() == game.GetJerry() || (game.GetTom() > 50 || game.GetTom() < 1))
                    {
                        winner += " Jerry";
                    }
                    game.SetNum();
                    Console.WriteLine(game.ToString());
                    Console.WriteLine(game.GetNum());
                }
            }
            Console.WriteLine(winner);
        }
    }
}
