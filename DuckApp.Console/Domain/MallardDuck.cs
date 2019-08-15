using DuckApp.Console.Models;

namespace DuckApp.Console.Domain
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        } 
    }
}