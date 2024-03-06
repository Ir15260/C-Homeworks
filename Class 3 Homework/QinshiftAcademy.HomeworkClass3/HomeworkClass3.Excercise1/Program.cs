
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


int[] ourIntArray = new int[6];

for (int i = 0; i < ourIntArray.Length; i++)
{
    Console.WriteLine($"Please enter integer no.{i + 1}:");
    string input = Console.ReadLine();
    bool parsingResult = int.TryParse(input, out ourIntArray[i]);

    if (!parsingResult)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        i--;
    }
}

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
    
