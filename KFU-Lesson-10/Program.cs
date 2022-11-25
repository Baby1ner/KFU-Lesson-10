using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            List<Team> teams = new List<Team>(); 
            for (int i=0;i < 4; i++)
            {
                teams.Add(new Team(Console.ReadLine()));
            }
            ((IBeach)game).Play(teams);
            ((IComputer)game).Play(teams);
            ((IFishing)game).Play(teams);
            ((IMail)game).Play(teams);
            ((IMouse)game).Play(teams);
            ((IOcean)game).Play(teams);
            ((ISlide)game).Play(teams);

            Console.WriteLine("Все игры закончились давайте подсчитаем общие баллы");
            for (int i = 0; i<teams.Count; i++)
            {
                Console.WriteLine($"Команда {teams[i].Name} получила {teams[i].Ball} баллов");
            }
            Console.WriteLine();
            
        }

    }
}
