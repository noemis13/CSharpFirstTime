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
            int[] numbers= { 5, 10, 15, 20, 25, 30};
            Console.WriteLine("Enter the number to verify if it exists:");
            int value = int.Parse(Console.ReadLine());

            int answer = Array.BinarySearch(numbers, value);

            if(answer < 0) {
                Console.WriteLine("Value does not exist into array.");
            } else{
                Console.WriteLine("Position is: {0}", answer);
            }
        }
    }
}
