using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //is a way to structure codes to mimic real life

            //names should be pasquel case. classes are comprised of fields/ fields are variables that belong to the class/
            //properties are a mix of methods and fields. properties are a way for people to access your fields
            //behaviors are methods for our class. methods are repeatable reusable section of code for ex. drive,park,stall for a car
            //constructors are the setup for our class. they allow to control the state of creation. 
            //properties allow to dictate how our fields are accessed.

            Cat cat1 = new Cat();
            Cat cat2 = new Cat("Neko", "black",3, 1, true,false,"Yes","sleep");

            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);
            cat1.Name = "Gato";
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Age);
            Console.WriteLine(cat1.Age);
            cat2.Eat();
            cat2.Run();
            cat2.Eat();
            cat2.Talk();
            cat1.Talk();
            cat1.FurColor = "Red";
            Console.WriteLine(cat1.FurColor);
            Dog coco = new Dog();
            coco.Run();
            coco.Cuddle("Sam");
            SuperHero goodGuy = new SuperHero("Super Good Guy");
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.NextLevel();
        }
    }
}
