using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Cat
    {
        
        //fields that will be used in the class
        //private means only people that have access is the class itself meaning cats only
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;
        //a private field will have a public property

        //properties do not have a parenthesis like methods do ()
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string FurColor { get; set; }
        public int FurLength { get; set; }

        public int Age
        {
            get { return this.age; }
        }

        //constructor is named same as class
        //every class needs a default constructor
        public Cat()
        {
            this.name = "Mittens";
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat (int age)
        {

        }
        
        
        //second constructor is overload
        public Cat(string name, string furColor, int furLength, int age, bool isMale, bool isHungry, string isCatFixed, string sleep)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
            
        }

        public void Eat ()
        {
            if (isHungry)
            {
                isHungry = false;
                Console.WriteLine("I'm stuffed");
            }
            else if (!isHungry)
            {
                Console.WriteLine("I'm good no food for me");
            }
        }

        public void Run()
        {
            Console.WriteLine("I am running really fast!");
            this.isHungry = true;
        }
        public void Sleep()
        {
            Console.WriteLine("I'm sleeping...zzzzzzz");
        }
        public void Talk()
        {
            Console.WriteLine("My name is {0} and yes I can talk",this.name);
        }
    }
}
