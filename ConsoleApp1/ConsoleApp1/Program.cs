using System;
using System.Threading.Tasks;

namespace ConsoleApp1{

    class Program{

        enum DaysOfWeekeend {
            Saturday,
            Sunday
        }

        static void Main(string[] args){
            //SimpleCalculator.Calculator();
            conditionalNot();
            //Using enum
            /*DaysOfWeekeend today = DaysOfWeekeend.Saturday;
            Console.WriteLine(today);
            */
        }
        static void conditionalNot() {
            //(conditional)? true : false
            int x = 10;
            int y = 11;

            int biggestNumber = x > y ? x : y;
            Console.WriteLine(biggestNumber);
        }
        static void Conditional() {
            //int x;
            //int y;
            //x = 10;
            //y = x + 20;
            //Console.WriteLine("Result: " + y);
            //Console.ReadLine();

            //String myName;
            //myName = "Noemi Scherer";

            //var test = " value";

            //Console.WriteLine(myName+ test);
            //Console.ReadLine();

            Console.WriteLine("Would you preffer1, 2 or 3:");
            String userValue;
            userValue = Console.ReadLine();

            String message = "";

            if (userValue == "1") {
                message = "You choose 1";
            } else if (userValue == "2") {
                message = "You choose 2";
            } else if (userValue == "3") {
                message = "Yo choose 3";
            } else {
                message = "Sorry, wrong number :(";
            }
            Console.WriteLine(message);
        }
    }
}
