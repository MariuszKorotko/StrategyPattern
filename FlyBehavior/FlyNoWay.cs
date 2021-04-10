using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
    public class FlyNoWay : IFlyBehvior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
