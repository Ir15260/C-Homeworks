//Take one string from the input and print its last 5 characters.

string addSentence = ""; 

while (true)
{
    Console.WriteLine("Enter a sentence:");
    string sentence = Console.ReadLine();

    if (string.IsNullOrEmpty(sentence))
    {
        Console.WriteLine("You haven't added anything.");
    }
    else
    {
        addSentence = sentence;
        break;
    }
}

int sentenceLength = addSentence.Length;

string lastFiveCaracters = addSentence.Substring(sentenceLength - 5);

Console.WriteLine(lastFiveCaracters);