using DuckApp.Console.Interfaces;

namespace DuckApp.Console.Models
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}