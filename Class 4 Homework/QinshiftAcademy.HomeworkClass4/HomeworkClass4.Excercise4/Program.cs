//Bonus Take a sentence as input and print its largest word.


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

string[] splitString = addSentence.Split(" ");


string largestWord = "";
int maxLength = 0;

foreach (string item in splitString)
{
    
    if (item.Length > maxLength)
    {
        largestWord = item;
        maxLength = item.Length;
    }
}

Console.WriteLine($"The largest word in the sentence is: {largestWord}");