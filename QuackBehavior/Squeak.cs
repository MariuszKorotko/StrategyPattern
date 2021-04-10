using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
