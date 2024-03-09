//Create a function that takes a number as input. This method should return the sum of the digits in the number.


        double parsedFirstNumber;
        while (true)
        {
            Console.WriteLine("Please enter the First number");
            string firstNumber = Console.ReadLine();
            bool parsingResult1 = double.TryParse(firstNumber, out parsedFirstNumber);

            if (!parsingResult1)
            {
                Console.WriteLine("Invalid input. Please enter a valid number");
            }
            else
            {
                double sum = CheckNumbers(parsedFirstNumber);
                Console.WriteLine("Sum of digits: " + sum);
                break;
            }
        }
   

    double CheckNumbers(double number)
    {
       
        string numberString = number.ToString();

        double sum = 0;

       
        foreach (char digitChar in numberString)
        {
           
            sum += double.Parse(digitChar.ToString());
        }

        return sum;
    }
