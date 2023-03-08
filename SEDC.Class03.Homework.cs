
// TASK 1

//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array.

using System;

Console.WriteLine("Please enter the inputs");
int[] intArray = new int[6];
string one  = Console.ReadLine(); 
intArray[0] = int.Parse(one);
string two = Console.ReadLine();
intArray[1] = int.Parse(two);
string three = Console.ReadLine();
intArray[2] = int.Parse(three);
string four = Console.ReadLine();
intArray[3] = int.Parse(four);
string  five = Console.ReadLine();
intArray[4] = int.Parse(five);
string six = Console.ReadLine();
intArray[5] = int.Parse(six);
int sumOfEven = 0;
foreach(int i in intArray)
{
    if(i%2 == 0)
    {
         sumOfEven= sumOfEven+i;
    }
}
Console.WriteLine("The sum of the even numbers is: " + sumOfEven);


// TASK 2
//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[5] { "Kenz", "Pece", "Anes", "Denis", "Ernes" };
Console.WriteLine("Please select the group, to see the students. Available groups: 1 & 2");
string input = Console.ReadLine();
switch (input)
{
    case "1":
        Console.WriteLine("The students of G1 are:");
        foreach(string student in studentsG1)
        {
            Console.WriteLine(student); 
        }
        break;
    case "2":
        Console.WriteLine("The students of G 2 are:");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);     
        }
        break;
    default:
        Console.WriteLine("Invalid input!");
        break;

}