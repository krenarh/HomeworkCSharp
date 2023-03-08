// See https://aka.ms/new-console-template for more information

#region TASK 1
// TASK 1

//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

using System.Diagnostics.Metrics;
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

Console.WriteLine("Please enter a number");
string one = Console.ReadLine();
bool parseOne = int.TryParse(one, out int inputOne);

Console.WriteLine("Please enter another number");
string two = Console.ReadLine();
bool parseTwo = int.TryParse(two, out int inputTwo);
int result;

Console.WriteLine("Please enter one of the following operations: +; -; *; /");

string operation = Console.ReadLine();
switch(operation)
{
    case "+":
        result = inputOne + inputTwo;
        Console.WriteLine(inputOne + " + " + inputTwo + " = " + result); 
        break;
    case "-":
        result = inputOne - inputTwo;
        Console.WriteLine(inputOne + " - " + inputTwo + " = " + result);
        break;
        case "*":
        result = inputOne * inputTwo;
        Console.WriteLine(inputOne + " * " + inputTwo + " = " + result);
        break;
        case "/":
        result = inputOne / inputTwo;
        Console.WriteLine(inputOne + " / " + inputTwo + " = " + result);
        break;  
        default:
        Console.WriteLine("Invalid operation");
        break;
}
#endregion

#region TASK 2

// TASK 2

//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18


Console.WriteLine("Enter the first number");
string numOne = Console.ReadLine();
double convertedNumOne = Convert.ToDouble(numOne);
Console.WriteLine("Enter the second number");
string numTwo = Console.ReadLine();
double convertedNumTwo = Convert.ToDouble(numTwo);
Console.WriteLine("Enter the third number");
string numThree= Console.ReadLine();
double convertedNumThree = Convert.ToDouble(numThree);
Console.WriteLine("Enter the fourth number");
string numFour= Console.ReadLine();
double convertedNumFour = Convert.ToDouble(numFour);
double average = (convertedNumOne + convertedNumTwo + convertedNumThree + convertedNumFour) / 4;     
Console.WriteLine(average);

#endregion

#region TASK 3

// TASK 3

//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.WriteLine("Please enter the first number");
string firstNumber = Console.ReadLine();
bool first = int.TryParse(firstNumber, out int firstNumberParsed);
Console.WriteLine("Please enter the second number");
string secondNumber = Console.ReadLine();
bool second = int.TryParse(secondNumber, out int secondNumberParsed);
int onHold = secondNumberParsed;
Console.WriteLine("Swapping numbers");
secondNumberParsed = firstNumberParsed;
firstNumberParsed = onHold;
Console.WriteLine("The first number now is: " + firstNumberParsed);
Console.WriteLine("The second number now is: " + secondNumberParsed);


#endregion