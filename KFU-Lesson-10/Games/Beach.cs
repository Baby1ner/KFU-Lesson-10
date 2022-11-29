using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_10
{
    internal class Beach : IStrategy
    {
        static Random random = new Random();
        public void Play(List<Team> teams)
        {
            Console.WriteLine("Начинается игра на пляжу");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 5);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }
    }
}
