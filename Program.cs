using System;
using System.Collections.Generic;
using DesignPatterns.abstract_factory;
using DesignPatterns.exam.exercise1;
using DesignPatterns.exam.exercise1.states;
using DesignPatterns.iterator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            GameContext g = new GameContext(new DuringGame());
            g.SpaceshipHit(20);
            g.SpaceshipHit(20);
            g.SpaceshipHit(2);
            g.SpaceshipHit(15);
            g.SpaceshipHit(5);
        }
    }
}