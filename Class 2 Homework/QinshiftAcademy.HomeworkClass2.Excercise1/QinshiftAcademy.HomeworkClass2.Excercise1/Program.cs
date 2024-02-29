
//Create a new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the fourth number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

double firstNumber = 10;
double secondNumber = 15;
double thirdNumber = 20;
double fourthNumber = 30;

double averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

Console.WriteLine($"The Average Number out of the 4 is : {averageNumber}");

Console.WriteLine("Imput the First Number");
string inputFirstNumber = Console.ReadLine();
double convertedFirstNumber = Convert.ToDouble(inputFirstNumber);

Console.WriteLine("Imput the Second Number");
string inputSecondNumber = Console.ReadLine();
double convertedSecondNumber = Convert.ToDouble(inputSecondNumber);

Console.WriteLine("Imput the Third Number");
string inputThirdNumber = Console.ReadLine();
double convertedThirdNumber = Convert.ToDouble(inputThirdNumber);

Console.WriteLine("Imput the Forth Number");
string inputForthNumber = Console.ReadLine();
double convertedForthNumber = Convert.ToDouble(inputForthNumber);

double convertedResultAverageNumber = (convertedFirstNumber + convertedSecondNumber + convertedThirdNumber + convertedForthNumber) / 4;

Console.WriteLine($"The Converted Average Number out of the 4 is : {convertedResultAverageNumber}");
