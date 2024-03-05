//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25 Try to solve the task in bot ways, using if and switch.


Console.WriteLine("Please enter the first number");
string firstNumber = Console.ReadLine();
double parsedfirstNumber;
bool parsingResult1 = double.TryParse(firstNumber, out parsedfirstNumber);

Console.WriteLine("Please enter the Second number");
string secondNumber = Console.ReadLine();
double parsedSecondNumber;
bool parsingResult2 = double.TryParse(secondNumber, out parsedSecondNumber);

Console.WriteLine("Please enter one of these  +, - , * , /");
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
}
else
{
    Console.WriteLine("Invalid simbol - Please enter one of these  +, - , * , /");
}

