
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14



Console.WriteLine("Please enter the first number");
string firstNumber = Console.ReadLine();
int parsedfirstNumber;
bool parsingResult1 = int.TryParse(firstNumber, out parsedfirstNumber);

Console.WriteLine("Please enter the Second number");
string secondNumber = Console.ReadLine();
int parsedSecondNumber;
bool parsingResult2 = int.TryParse(secondNumber, out parsedSecondNumber);

Console.WriteLine("Please enter the Third number");
string thirdNumber = Console.ReadLine();
int parsedThirdNumber;
bool parsingResult3 = int.TryParse(thirdNumber, out parsedThirdNumber);

Console.WriteLine("Please enter the Forth number");
string forthNumber = Console.ReadLine();
int parsedForthNumber;
bool parsingResult4 = int.TryParse(forthNumber, out parsedForthNumber);

Console.WriteLine("Please enter the Fifth number");
string fifthNumber = Console.ReadLine();
int parsedFifthNumber;
bool parsingResult5 = int.TryParse(fifthNumber, out parsedFifthNumber);

Console.WriteLine("Please enter the Sixt number");
string sixtNumber = Console.ReadLine();
int parsedSixtNumber;
bool parsingResult6 = int.TryParse(sixtNumber, out parsedSixtNumber);

if(parsingResult1 && parsingResult2 && parsingResult3 && parsingResult4 && parsingResult5 && parsingResult6)
{
    int[] ourIntArray = new int[6];
    ourIntArray[0] = parsedFifthNumber;
    ourIntArray[1] = parsedSecondNumber;
    ourIntArray[2] = parsedThirdNumber;
    ourIntArray[3] = parsedForthNumber;
    ourIntArray[4] = parsedFifthNumber;
    ourIntArray[5] = parsedSixtNumber;

    Console.WriteLine("Even Values in the array:");
    for (int i = 0; i < ourIntArray.Length; i++)
    {
        if (ourIntArray[i] % 2 == 0)
        {
            Console.WriteLine(ourIntArray[i]);
        }
     
    }

    int sumOfEvenNumbers = 0;
    for (int i = 0; i < ourIntArray.Length; i++)
    {
        if (ourIntArray[i] % 2 == 0)
        {
            sumOfEvenNumbers += ourIntArray[i];
        }
    }
    Console.WriteLine("Sum of even numbers in the array: " + sumOfEvenNumbers);
}

else
{
    Console.WriteLine("Invalid input");
}