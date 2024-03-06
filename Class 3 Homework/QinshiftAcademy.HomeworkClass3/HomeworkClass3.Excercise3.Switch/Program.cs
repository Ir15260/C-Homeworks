//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25 Try to solve the task in bot ways, using if and switch.



double parsedfirstNumber;
do
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
        // Input is valid, exit the loop
        break;
    }

} while (true);



double parsedSecondNumber;

do
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

} while (true);




while (true)
{
    Console.WriteLine("Please enter one of these +, -, *, /");
    string sign = Console.ReadLine();


    if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
    {
        switch (sign)
        {
            case "+":
                double sum = parsedfirstNumber + parsedSecondNumber;
                Console.WriteLine(sum);
                break;

            case "-":
                double minus = parsedfirstNumber - parsedSecondNumber;
                Console.WriteLine(minus);
                break;
            case "*":
                double multiply = parsedfirstNumber * parsedSecondNumber;
                Console.WriteLine(multiply);
                break;
            case "/":
                double devide = parsedfirstNumber / parsedSecondNumber;
                Console.WriteLine(devide);
                break;
        }
        break;
    }
    else
    {
        Console.WriteLine("Invalid simbol - Please enter one of these  +, - , * , /");
    }
}
