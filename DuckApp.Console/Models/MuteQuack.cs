using DuckApp.Console.Interfaces;

namespace DuckApp.Console.Models
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("<< Silence >>");
        }
    }
}