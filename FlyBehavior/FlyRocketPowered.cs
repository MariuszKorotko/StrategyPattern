using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehavior
{
    public class FlyRocketPowered : IFlyBehvior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
