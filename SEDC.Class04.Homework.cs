

// TASK 1

//Take one string from the input and print its last 5 characters.
Console.WriteLine("Type Something");
string getLast5Char = Console.ReadLine();
string splitedString = getLast5Char.Substring(getLast5Char.Length - 5);
Console.WriteLine(splitedString);


//// TASK 2

////Take a sentence as input and print its words.
Console.WriteLine("Please enter a sentence");
string sentence = Console.ReadLine();
string[] splitedSentence = sentence.Split(" ");
Console.WriteLine("The words of the sentence are: ");
foreach(string s in splitedSentence)
{
   Console.WriteLine(s);
}


// TASK 3
//Create a function that takes a number as input. This method should return the sum of the digits in the number.
//Console.WriteLine("Please enter a number!");



// TASK 4

//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today.

Console.WriteLine("Please type your birthday date(MM/DD/YYYY or MM.DD.YYYY).");
string input1 =  Console.ReadLine();
DateTime convertedInput = DateTime.Parse(input1);
DateTime todaysDate = DateTime.Today;
var age = todaysDate.Subtract(convertedInput);
double years = age.Days / 365.25;
int yearss = Convert.ToInt32(Math.Floor(years));
if (convertedInput.Month == todaysDate.Month && convertedInput.Day == todaysDate.Day)
{
    Console.WriteLine("Happy birthday! Congrats on becoming " + (yearss + 1));
}
else
{
    Console.WriteLine("You are " + yearss);
}