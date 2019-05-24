using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class UsingLoop {

        public void doWhile() {
            //int x = 5;
            //do {
            //    Console.WriteLine("Value {0}. ", x);
            //    x++;
            //} while (x < 6);

            //WHILE LOOP-------------------
            //Console.WriteLine("hello");
            //string response = Console.ReadLine();
            //while (response == "again")
            //{
            //    Console.WriteLine("hello");
            //    response = Console.ReadLine();
            //}
            //DO WHILE LOOP----------------------------
            string response;
            do {
                Console.WriteLine("hello");
                response = Console.ReadLine();
            } while (response == "again");
        }

        //Lecture 28: Exercise 1
        /*
         * 
         *  Write a console-based application that prompts a user for an
            hourly pay rate. While the user enters values less than $5.65
            or greater than $49.99, continue to prompt the user. Before
            the program ends, display the valid pay rate
         * 
         * */

        public static void hourlyPayRate() {

            double payRate;
            do {
                Console.WriteLine("Enter the value:");
                payRate = double.Parse(Console.ReadLine());
            } while (payRate < 5.65 || payRate > 49.99);

            Console.WriteLine("Payrate is: {0}", payRate);
        }

        //Lecture 29: Exercise 2
        /*
         * 
         * Write a console-based application that sums the integers
           from 1 to 50
         * 
         * */

        public static void sumInt() {
            int i = 1;
            int sum = 0;
            while(i<=50) {
                sum = sum + i;
            }
            Console.WriteLine("Final value: {0}", sum);
        }

        //Lecture 30: Exercise 3
        /*
         * EDIT TO USE LOOPS
         * 
         *  * Write a program that generates a random number between 1 and 10. Ask a user
         * to guess the random number, then display the random number and a message
         * indicating whether the user's guess was too high, too low, or correct.
         * 
         * ------HINT-------
         * You can create a random number that is at least min but less than max using the following statements
         * Random randomGenerator = new Random();
         * int randomNumber = randomGenerator.Next(min,max);  1, 11
         * 
         * */

        public static void radomNumbers() {
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 11);
            int usersGuess;
            int amountOfGuesses = 0;
            do {
                Console.WriteLine("Guess the random number");
                usersGuess = int.Parse(Console.ReadLine());
                if (usersGuess < randomNumber) {
                    Console.WriteLine("Your guess was too low");
                } else if (usersGuess > randomNumber) {
                    Console.WriteLine("Your guess was too high");
                } else {
                    Console.WriteLine("Your guess is correct");
                }
                amountOfGuesses++;

            } while (usersGuess != randomNumber);
            Console.WriteLine("You guessed {0} times", amountOfGuesses);
        }
    }
}
