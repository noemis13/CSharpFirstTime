using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class MethodsExercises {

        public static void MainClass() {
            //MainEx1();
            MainEx2();
            MainEx3();
        }

        //Lecture 48: Exercise 1
        /*
         * 
         *  Create a console-based application whose Main() method
            asks the user to input an integer and then calls a method
            named MultiplicationTable(), which displays the
            results of multiplying the integer by each of the numbers
            2 through 10
         * 
         * */

        private static void MainEx1() {
            Console.WriteLine("Enter a integer number:");
            int number = int.Parse(Console.ReadLine());
            MultiplicationTable(number);
        }

        private static void MultiplicationTable(int number) {

            for(int i=2; i<=10; i++) {
                int result = number * i;
                Console.WriteLine("{0} * {1} = {2}", number, i, result);
            }

        }


        //Lecture 49: Exercise 2
        /*
         * 
         *  Create a console-based program whose Main() method
            prompts the user for an integer value and, in turn, passes
            the value to a method that squares the number and to
            a method that cubes the number. The Cube() method
            should call the Square() method. The Main() method
            displays the results returned from each of the other methods.
         */

        private static void MainEx2() {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            int squared = Square(number);
            Console.WriteLine("{0} squared is {1}", number, squared);

            int cubed = Cube(number);
            Console.WriteLine("{0} cubed is {1}", number, cubed);

        }

        private static int Square(int number) {
            return number * number;
        }

        private static int Cube(int number) {
            int anser = Square(number);
            return anser * number;
        }
        //Lecture 50: Exercise 3
        /*
         * 
         *  Create a method named Sum() that accepts any number of
            integer parameters and displays their sum. Write a Main()
            method that demonstrates the Sum() method works correctly
            when passed one, three, or five integers, or an array of ten
            integers
         * 
         * 
         * */
        static void MainEx3() {
            Sum(5);
            Sum(5, 10, 15);
            Sum(5, 10, 15, 20, 25);

            int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Sum(myArray);
        }
        private static void Sum(params int[] myArray) {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++) {
                sum += myArray[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }

    }
}
