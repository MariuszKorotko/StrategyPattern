using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
    public class FlyWithWings : IFlyBehvior
    {
        public FlyWithWings()
        {
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}
