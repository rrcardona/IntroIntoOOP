using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Dog
    {
        private int hairLength;
        private int height;
        private int runningSpeed;
        private double weight;

        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog ()
        {
            this.weight = 220d;
            this.height = 3;
            this.runningSpeed = 80;
            this.hairLength = 3;

        }
        public Dog (int hairLength, int height, int runningSpeed, double weight)
        {
            this.weight = weight;
            this.height = height;
            this.hairLength = hairLength;
            this.runningSpeed = runningSpeed;
        }
        public void Run()
        {
            Console.WriteLine("I am running faster then you!");
        }
        public void Cuddle(string name)
        {
            Console.WriteLine("{0} and the dog are cuddling... the dog is the big spoon",name);
        }
    }
}
