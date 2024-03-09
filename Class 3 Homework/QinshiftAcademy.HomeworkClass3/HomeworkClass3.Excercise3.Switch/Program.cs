//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25 Try to solve the task in bot ways, using if and switch.



double parsedfirstNumber;
while(true)
{
    Console.WriteLine("Please enter the First number");
    string firstNumber = Console.ReadLine();
    bool parsingResult1 = double.TryParse(firstNumber, out parsedfirstNumber);

    if (!parsingResult1)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
    else
    {
        
        break;
    }

}



double parsedSecondNumber;

while(true)
{
    Console.WriteLine("Please enter the Second number");
    string secondNumber = Console.ReadLine();
    bool parsingResult2 = double.TryParse(secondNumber, out parsedSecondNumber);

    if (!parsingResult2)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
    else
    {

        break;
    }

} 



while (true)
{
    Console.WriteLine("Please enter one of these +, -, *, /");
    string sign = Console.ReadLine();

    if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
    {
        if (sign == "+")
        {
            double sum = parsedfirstNumber + parsedSecondNumber;
            Console.WriteLine(sum);
        }
        else if (sign == "-")
        {
            double minus = parsedfirstNumber - parsedSecondNumber;
            Console.WriteLine(minus);
        }
        else if (sign == "*")
        {
            double multiply = parsedfirstNumber * parsedSecondNumber;
            Console.WriteLine(multiply);
        }
        else
        {
            double divide = parsedfirstNumber / parsedSecondNumber;
            Console.WriteLine(divide);
        }


        break;
    }
    else
    {
        Console.WriteLine("Invalid symbol - Please enter one of these +, -, *, /");
    }
}