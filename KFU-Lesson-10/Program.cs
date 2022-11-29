using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU_Lesson_10
{



    public interface IStrategy
    {
        void Play(List<Team> team);
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>(); 
            for (int i=0;i < 4; i++)
            {
                Console.WriteLine("Введите название страны участвующей в Большой Гонке ");
                teams.Add(new Team(Console.ReadLine()));
            }
            
            Game game = new Game(teams);
            game.ChoiceGame(new Beach());
            game.PlayGame();
            game.ChoiceGame(new Computer());
            game.PlayGame();
            game.ChoiceGame(new Fishing());
            game.PlayGame();
            game.ChoiceGame(new Mail());
            game.PlayGame();
            game.ChoiceGame(new Mouse());
            game.PlayGame();
            game.ChoiceGame(new Ocean());
            game.PlayGame();
            game.ChoiceGame(new Slide());
            game.PlayGame();
            game.Print();
            Console.ReadLine();
        }

    }
}
