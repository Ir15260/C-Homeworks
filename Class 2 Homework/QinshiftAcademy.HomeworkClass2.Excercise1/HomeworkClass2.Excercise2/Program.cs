

//Create a new console application called “SwapNumbers”. Input 2 numbers from the console and
//then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:
//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5




double firstNumber = 5;
double secondNumber = 8;

firstNumber = firstNumber + secondNumber;
secondNumber = firstNumber - secondNumber;
firstNumber = firstNumber - secondNumber;

Console.WriteLine($"This is the First Number: {firstNumber} and this is the Second Number: {secondNumber}");

Console.WriteLine("Imput the First Number");
string inputFirstNumber = Console.ReadLine();
double convertedFirstNumber = Convert.ToDouble(inputFirstNumber);

Console.WriteLine("Imput the Second Number");
string inputSecondNumber = Console.ReadLine();
double convertedSecondNumber = Convert.ToDouble(inputSecondNumber);

convertedFirstNumber = convertedFirstNumber + convertedSecondNumber;
convertedSecondNumber = convertedFirstNumber - convertedSecondNumber;
convertedFirstNumber = convertedFirstNumber - convertedSecondNumber;

Console.WriteLine($"This is the First Number: {convertedFirstNumber} and this is the Second Number: {convertedSecondNumber}");