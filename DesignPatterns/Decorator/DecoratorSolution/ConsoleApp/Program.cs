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
            Beverage beverage = new Espresso();
            Console.WriteLine(String.Format("Description: {0}, Cost: ${1}", beverage.Description(), beverage.Cost()));

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(String.Format("Description: {0}, Cost: ${1}", beverage2.Description(), beverage2.Cost()));

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            beverage3 = new Soy(beverage3);
            Console.WriteLine(String.Format("Description: {0}, Cost: ${1}", beverage3.Description(), beverage3.Cost()));

            Console.WriteLine("Please press <<ENTER>> to quit program");
            Console.ReadLine();
        }
    }
}
