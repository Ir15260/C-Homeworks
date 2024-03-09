using Excersise_1;


int parsedFirstNumber;
while (true)
{
    Console.WriteLine("Please enter the First number");
    string firstNumber = Console.ReadLine();
    bool parsingResult1 = int.TryParse(firstNumber, out parsedFirstNumber);

    if (parsedFirstNumber != 1 && parsedFirstNumber != 2 && parsedFirstNumber != 3)
    {
        Console.WriteLine("Invalid input. Please enter a valid number (1 to 3).");
    }
    else
    {
        Dog myDog = new Dog("Buddy", "Labrador", "Golden");

        switch (parsedFirstNumber)
        {
            case 1:
                string dogEats = myDog.Eat();
                Console.WriteLine(dogEats);
                break;

            case 2:
                string dogPlays = myDog.Play();
                Console.WriteLine(dogPlays);
                break;

            case 3:
                string dogChaseTail = myDog.ChaseTail();
                Console.WriteLine(dogChaseTail);
                break;

            default:
                Console.WriteLine("Invalid input. Please enter a valid number (1 to 3).");
                break;
        }

        break;
    }
}

