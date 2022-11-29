using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_10
{
    internal class Game 
    {
        public IStrategy strategy { get; set; }
        public List<Team> teams { get; set; }

        public Game(List<Team> teams)
        {
            this.teams = teams;
        }
        public void ChoiceGame(IStrategy strategy)
        {
            this.strategy = strategy;
        }


        public void PlayGame()
        {
            if (strategy == null)
            {
                Console.WriteLine("Такой игры не существует");
                return;
            }

            strategy.Play(teams);
        }

        public void Print()
        {
            for (int i = 0 ; i < teams.Count; i++)
            {
                Console.WriteLine($"У команды {teams[i].Name}: {teams[i].Ball} балла(ов)");
            }
        }
    }
}
