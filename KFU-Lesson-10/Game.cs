using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_10
{
    internal class Game : IBeach, IComputer, IFishing, IMail, IMouse, IOcean, ISlide
    {
        static Random random = new Random();


        void IBeach.Play(List<Team> teams)
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

        void IComputer.Play(List<Team> teams)
        {
            Console.WriteLine("Начинается игра в доту");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 8);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }

        void IFishing.Play(List<Team> teams)
        {
            Console.WriteLine("Начинается рыбалка на баллы");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 3);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }

        void IMail.Play(List<Team> teams)
        {
            Console.WriteLine("Начинается игра на доставку почты");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 9);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }

        void IMouse.Play(List<Team> teams)
        {
            Console.WriteLine("Начинается игра в мышеловку");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 15);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }

        void IOcean.Play(List<Team> teams)
        {
            Console.WriteLine("Начинается игра в море");
            for (int i = 0; i < teams.Count; i++)
            {
                int rand = random.Next(1, 10);
                Console.WriteLine($"Команда {teams[i].Name} получила {rand} очков");
                teams[i].Ball += rand;
            }
            Console.WriteLine();
        }

        void ISlide.Play(List<Team> teams)
        {
            Console.WriteLine("Начинается игра на горке");
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
