# CSharpFirstTime
## Fundamentals of Programming: Understanding C# 
##- Using Data
## - Making decisions
##- Looping: 
#### doWhile, while, for.
#### Exercises:
1. Write a console-based application that prompts a user for an hourly pay rate. While the user enters values less than $5.65 or greater than $49.99, continue to prompt the user. Before the program ends, display the valid pay rate.

2. Write a console-based application that sums the integers from 1 to 50

3. EDIT TO USE LOOPS: Write a program that generates a random number between 1 and 10. Ask a user to guess the random number, then display the random number and a message indicating whether the user's guess was too high, too low, or correct.
         ------HINT-------
         You can create a random number that is at least min but less than max using the following statements;
         Random randomGenerator = new Random();
         int randomNumber = randomGenerator.Next(min,max);  1, 11
         
##- Arrays
##- Methods: 
#### Creating methods, pass by reference and value, ref keyword, out keyword, params keyword, method overloading.
#### Exercises:
1. Create a console-based application whose Main() method asks the user to input an integer and then calls a method named MultiplicationTable(), which displays the results of multiplying the integer by each of the numbers 2 through 10.

2. Create a console-based program whose Main() method prompts the user for an integer value and, in turn, passes the value to a method that squares the number and to a method that cubes the number. The Cube() method should call the Square() method. The Main() method displays the results returned from each of the other methods.

3. Create a method named Sum() that accepts any number of integer parameters and displays their sum. Write a Main()
method that demonstrates the Sum() method works correctly when passed one, three, or five integers, or an array of ten integers.


##- Classes

