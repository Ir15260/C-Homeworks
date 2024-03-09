//Take a sentence as input and print its words.



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

foreach (string item in splitString)
{
    Console.WriteLine(item);
}