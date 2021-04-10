using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
