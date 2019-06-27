using System;
using System.Collections.Generic;
using DesignPatterns.abstract_factory;
using DesignPatterns.exam.exercise1;
using DesignPatterns.exam.exercise1.states;
using DesignPatterns.exercise2;
using DesignPatterns.iterator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {   
            // // Example exercise 1         
            // GameContext g = new GameContext(new DuringGame());
            // g.SpaceshipHit(20);
            // g.SpaceshipHit(20);
            // g.SpaceshipHit(2);
            // g.SpaceshipHit(15);
            // g.SpaceshipHit(5);

            // Example exercise 2
            Composite root = new Composite(2);
            Composite child = new Composite(2);
            child.addChild(new Leaf(2));
            root.addChild(child);
            root.addChild(new Leaf(2));
            root.addChild(new Leaf(8));
            Console.WriteLine(root.Sum());
            Console.WriteLine(isEvenRecursionExercise2(root));
        }

        static bool isEvenRecursionExercise2(Component c) {
            if (!c.isEven()) {
                return false;
            }
            bool isChildrenEven = true;
            if (c.getChildren() != null) {
                foreach(Component child in c.getChildren()){                    
                    isChildrenEven = isChildrenEven && isEvenRecursionExercise2(child);
                }

                return isChildrenEven;
            }

            return true;
        }
    }
}