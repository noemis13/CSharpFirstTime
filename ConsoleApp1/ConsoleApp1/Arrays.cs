using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1 {
    class Arrays {

        public void arrayManipulation() {
            //Lecture 32: Creating an Array
            int[] myArray = new int[3];
            myArray[0] = 5;
            myArray[1] = 6;
            myArray[2] = 7;

            int[] myArray2 = new int[3] { 5, 6, 7 };
            int[] myArray3 = new int[] { 5, 6, 7 };
            int[] myArray4 = { 5, 6, 7 };

            Console.WriteLine(myArray4[1]);

            //Lecture 34: Searching an Array Using Loops
            string[] students = { "Bob", "Ted", "Tom", "Fred" };
            int[] grades = { 77, 50, 78, 99 };

            Console.WriteLine("Enter students name to search for");
            string studentsName = Console.ReadLine();

            bool contains = false;
            int studentGrade = 0;
            for (int i = 0; i < students.Length; i++) {
                if (studentsName == students[i]) {
                    contains = true;
                    studentGrade = grades[i];
                    break;
                }
            }
        }

        public static void binarySearch() {
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("Enter the number to verify if it exists:");
            int value = int.Parse(Console.ReadLine());

            int answer = Array.BinarySearch(numbers, value);

            if (answer < 0) {
                Console.WriteLine("Value does not exist into array.");
            } else {
                Console.WriteLine("Position is: {0}", answer);
            }
        }

        public static void sortArray() {
            int[] numbers = { 30, 10, 150, 100, 20, 50 };
            Array.Sort(numbers);
            //Reverse array
            //Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void multidimentionalArray() {
            //Lecture 36: Brief Look at Multidimensional Arrays 
            //Rectangular Array

            int[,] myArray = new int[3, 4];
            myArray[0, 0] = 5;
            myArray[0, 1] = 6;
            myArray[0, 2] = 7;
            myArray[0, 3] = 8;

            myArray[1, 0] = 5;
            myArray[1, 1] = 6;
            myArray[1, 2] = 7;
            myArray[1, 3] = 8;

            myArray[2, 0] = 5;
            myArray[2, 1] = 6;
            myArray[2, 2] = 7;
            myArray[2, 3] = 8;

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    Console.Write(myArray[i, j]);
                }
                Console.WriteLine();
            }

            //Jagged Array
            int[][] myJArray = new int[3][];
            myJArray[0] = new int[4] { 5, 6, 7, 8 };
            myJArray[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myJArray[2] = new int[2] { 1, 2 };

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < myJArray[i].Length; j++) {
                    Console.Write(myJArray[i][j]);
                }
                Console.WriteLine();
            }
        }

        /*
         * 
         *                                                   EXERCISESSSS
         * 
         */

        //Lecture 37: Exercise 1
        /*
         *  Write a program for a package delivery service. The program
            contains an array that holds the ten zip codes to which the
            company delivers packages. Prompt a user to enter a zip
            code and display a message indicating whether the zip code
            is one to which the company delivers.
         * 
         * */

        public static void zipCode() {
            string[] zipCodes = { "10000", "11567", "445566", "778855", "334455", "667788", "112233", "445522", "556677", "667789" };
            Array.Sort(zipCodes);

            Console.WriteLine("Enter the zip code: ");
            string zCode = Console.ReadLine();

            int foundZc = Array.BinarySearch(zipCodes, zCode);

            if(foundZc< 0) {
                Console.WriteLine("Sorry, the zip cod IS NOT belong to the company delivers");
            } else {
                Console.WriteLine("This zip code os on to wich the company delivers");
            }

        }

        //Lecture 38: Exercise 2
        /*
         * 
         *  Write a program that allows a teacher to enter in an amount of students. For each
         *  student ask the teacher to enter in their name and final score for the class. When
         *  the teacher is done entering the data, print the highest grade in the class, and the average grade
         *  for the class.
         * 
         * */

        public static void averageClass() {
            //Console.WriteLine("Enter the amount of students in your class");
            //int amountOfStudents = int.Parse(Console.ReadLine());

            //double averageGrade = 0;
            //double highestGrade = 0;
            //string highestGradeName = "";

            //string[] studentNames = new string[amountOfStudents];
            //double[] grades = new double[amountOfStudents];

            //for (int i = 0; i < amountOfStudents; i++) {
            //    Console.WriteLine("Enter student #{0} name", i + 1);
            //    string name = Console.ReadLine();
            //    studentNames[i] = name;
            //    Console.WriteLine("Enter student #{0} grade", i + 1);
            //    double grade = double.Parse(Console.ReadLine());
            //    grades[i] = grade;
            //    averageGrade += grade;
            //    if (grade > highestGrade) {
            //        highestGrade = grade;
            //        highestGradeName = name;
            //    }
            //}

            ////printing
            //averageGrade /= amountOfStudents;
            //Console.WriteLine("The average grade of the class is {0}", averageGrade);
            //Console.WriteLine("The highest grade of the class is {0} and their name was {1}", highestGrade, highestGradeName);
        }

        //Lecture 39: Exercise 3
        /*
         * 
         *  Create a game similar to Hangman in which a player guesses
            letters to try to replicate a hidden word. Store at least eight
            words in an array, and randomly select one to be the hidden
            word. Initially, display the hidden word using
            asterisks to represent each letter. Allow the user to guess letters
            to replace the asterisks in the hidden word until the user
            completes the entire word. If the user guesses a letter that is
            not in the hidden word, display an appropriate message. If
            the user guesses a letter that appears multiple times in the
            hidden word, make sure that each correct letter is placed.
         * 
         *  ----HINT----
         *  You will need to know about strings internal array
         *  strings Contains method
         *  strings Remove method
         *  strings Insert method
         *  strings Length property
         * 
         * */

        public static void Hangman() {
            string[] words = { "pineapple", "apple", "grape", "melon", "raspberry" };
            Random random = new Random();
            int randomIndex = random.Next(0, 5);
            string randomWord = words[randomIndex];
            
            Console.WriteLine("HANGMAN GAME");
            
            string showWord = "";
            for(int i = 0; i< randomWord.Length; i++) {
                showWord += "*";
            }

            while (showWord.Contains("*")) {
                Console.WriteLine("Your word:  {0}", showWord);
                Console.WriteLine("Select a letter>> ");
                char letter = char.Parse(Console.ReadLine());

                bool containsLetter = false;

                for (int i =0; i < randomWord.Length; i++) {
                    if(randomWord[i] == letter) {
                        showWord = showWord.Remove(i, 1);
                        showWord = showWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    } 
                }
                if(containsLetter == true) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes! {0} is in the word", letter);
                } else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0} is not in the word", letter);
                }
                Console.ResetColor();

            }
            //You won
            Console.WriteLine("Congratulations! You win! The word was {0}", showWord);
        }

    }

}

