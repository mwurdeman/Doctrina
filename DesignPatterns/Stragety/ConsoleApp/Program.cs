using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck woodDuck = new WoodDuck();
            Duck mallard = new MallardDuck();
            Console.WriteLine(mallard.performFly());
            Console.WriteLine(mallard.performQuack());
            Console.WriteLine(mallard.Swim());
            Console.WriteLine(mallard.Display());

            Console.WriteLine("Please press <<ENTER>> to end the program.");
            Console.ReadLine();
        }

        public void MakeDuckSpeak(Duck duck)
        {

        }
    }
}
