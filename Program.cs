using System;
using System.Collections.Generic;
using DesignPatterns.abstract_factory;
using DesignPatterns.exam.exercise1;
using DesignPatterns.exam.exercise1.states;
using DesignPatterns.exam.exercise10;
using DesignPatterns.exam.exercise12;
using DesignPatterns.exam.exercise3;
using DesignPatterns.exam.exercise5;
using DesignPatterns.exam.exercise6;
using DesignPatterns.exam.exercise7;
using DesignPatterns.exam.exercise8;
using DesignPatterns.exam.exercise9;
using DesignPatterns.exercise2;
using DesignPatterns.iterator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Example exercise 1         
            GameContext g = new GameContext(new DuringGame());
            g.SpaceshipHit(20);
            g.SpaceshipHit(20);
            g.SpaceshipHit(2);
            g.SpaceshipHit(15);
            g.SpaceshipHit(5);

            // Example exercise 2
            Composite root = new Composite(2);
            Composite child = new Composite(2);
            child.addChild(new Leaf(2));
            root.addChild(child);
            root.addChild(new Leaf(2));
            root.addChild(new Leaf(8));
            Console.WriteLine(root.Sum());
            Console.WriteLine(isEvenRecursionExercise2(root));

            // // Example exercise 3
            Mercedes c1 = new Mercedes();
            BMW c2 = new BMW();
            CarController cc = new CarController(c1);
            c1.StartDriving();
            c1.TurnLeft();
            cc.car = c2;
            cc.TurnRight();
            cc.DisplayLocation();
            ProxyCarController pcc = new ProxyCarController(cc);
            pcc.DisplayLocation();

            // // Example exercise 5
            LogFactory.GetLogWritter(LogEnum.Info).WriteLog();
            LogFactory.GetLogWritter(LogEnum.Error).WriteLog();
            LogFactory.GetLogWritter(LogEnum.Fatal).WriteLog();

            // // Example exercise 6
            FlyWeightPower fwp = new FlyWeightPower();
            fwp.addPowerNumber(2, 3);
            fwp.addPowerNumber(3, 2);
            fwp.addPowerNumber(3, 3);
            fwp.addPowerNumber(11, 2);
            PowerNumberCalculator calc = new PowerNumberCalculator();
            List<PowerNumber> powerNumbers = calc.calculatePowerNumbers(fwp);
            powerNumbers.ForEach(x => Console.WriteLine(x.calculation));            

            // Example exercise 7
            Chatroom chat = new Chatroom();
            Participant p1 = new Participant(1);
            Participant p2 = new Participant(2);
            Participant p3 = new Participant(3);
            chat.addParticipant(p1);
            chat.addParticipant(p2);
            p1.SendAll("hello!");
            p1.SendToUser(2, "Wanna netflix and chill?");
            p2.SendAll("Lets all netflix and chill!");

            // Example exercise 8
            DeadLiftWorkoutBuilder deadliftBuilder = new DeadLiftWorkoutBuilder();
            deadliftBuilder.buildWorkout();
            SquatWorkoutBuilder sb = new SquatWorkoutBuilder();
            sb.buildWorkout();

            // // Example exercise 9
            CarMakerFactoryBase normal = new NormalCarFactory();
            normal.createAC();
            normal.createBatery();
            normal.createEngine();
            normal.createLightSystem();
            normal.createSeats();
            normal.createTin();
            normal.createWheels();

            CarMakerFactoryBase hybrid = new HybridCarFactory();
            hybrid.createAC();
            hybrid.createBatery();
            hybrid.createEngine();
            hybrid.createLightSystem();
            hybrid.createSeats();
            hybrid.createTin();
            hybrid.createWheels();

            // // Example exercise 10
            WindowHandler h1 = new WindowHandler();
            WindowHandler h2 = new Shadow();
            WindowHandler h3 = new TickingBackground();
            WindowHandler h4 = new D3Light();
            WindowHandler h5 = new ColorfulBorder();
            h1.setNext(h2);
            h2.setNext(h3);
            h3.setNext(h4);
            h4.setNext(h5);
            h1.handle();

            // // Example exercise 12
            OfficeComputerPackBuilder b1 = new OfficeComputerPackBuilder();
            b1.buildComputerPack();
            SalonComputerPackBulider b2 = new SalonComputerPackBulider();
            b2.buildComputerPack();
            GamingComputerPackBulider b3 = new GamingComputerPackBulider();
            b3.buildComputerPack();
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