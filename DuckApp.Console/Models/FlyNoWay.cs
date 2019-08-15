using DuckApp.Console.Interfaces;

namespace DuckApp.Console.Models
{
    public class FlyNoWay : FlyBehavior 
    {
        public void fly()
        {
            System.Console.WriteLine("<< I cannot ly :( >>");
        }
    }
}