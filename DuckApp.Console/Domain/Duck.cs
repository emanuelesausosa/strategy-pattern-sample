using DuckApp.Console.Interfaces;

namespace DuckApp.Console.Domain
{
    public class Duck
    {
        protected FlyBehavior FlyBehavior;
        protected QuackBehavior QuackBehavior;

        public void PerformQuack()
        {
            QuackBehavior.quack();
        }

        public void PerformFly()
        {
            FlyBehavior.fly();
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }
}