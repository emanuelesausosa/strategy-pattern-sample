using DuckApp.Console.Interfaces;

namespace DuckApp.Console.Models
{
    public class FlyWithWings : FlyBehavior

    {
        public void fly()
        {
            System.Console.WriteLine("Fly With wings, yohoo");
        }
    }
}