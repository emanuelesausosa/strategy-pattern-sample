using DuckApp.Console.Interfaces;

namespace DuckApp.Console.Models
{
    public class Squack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Squack");
        }
    }
}