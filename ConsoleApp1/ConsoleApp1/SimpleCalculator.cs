using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class SimpleCalculator {

        public static void Calculator() {
            Console.WriteLine("Enter the first number: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator: ");
            string op = Console.ReadLine();

            float answer = 0;
            if(op.Equals("+")) {
                answer = value1 + value2;
                Console.WriteLine("{0} {1} {2} = {3}", value1, op, value2, answer);
            }else if (op.Equals("-")) {
                answer = value1 - value2;
                Console.WriteLine("{0} {1} {2} = {3}", value1, op, value2, answer);
            }else if (op.Equals("*")) {
                answer = value1 * value2;
                Console.WriteLine("{0} {1} {2} = {3}", value1, op, value2, answer);
            }else if (op.Equals("/")) {
                answer = value1 / value2;
                Console.WriteLine("{0} {1} {2} = {3}", value1, op, value2, answer);
            } else {
                Console.WriteLine("Sorry, invalid operator! :(");
            }
        }
    }
}
