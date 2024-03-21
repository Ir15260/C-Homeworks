//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the numbers in the order that the user entered them from the QUEUE

Queue<double> doubleQueue = new Queue<double>();
double parsedNumber;


while (true)
{
    Console.WriteLine("Please enter a number:");
    string enterNumber = Console.ReadLine();
    bool parsingResult = double.TryParse(enterNumber, out parsedNumber);

    if (parsingResult)
    {
        Console.WriteLine($"Parsed number: {parsedNumber}");
        doubleQueue.Enqueue(parsedNumber);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue; 
    }

   
    Console.Write("Do you want to enter another number? (Y/N): ");
    string input = Console.ReadLine();

    if (input.ToUpper() == "N")
    {
        foreach (var number in doubleQueue)
        {
            Console.WriteLine($"{number}");
        }
    }

    else if (input.ToUpper() == "Y") 
    {
        continue;
    }
   
    else
    {
        Console.WriteLine("please enter Y or N");
        continue;
    }
      
}
