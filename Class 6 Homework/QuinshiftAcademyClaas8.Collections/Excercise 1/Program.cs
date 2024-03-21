Console.WriteLine("====Dictonary====");

Dictionary<string, int> phonebook = new Dictionary<string, int>();



phonebook.Add("Ilija", 071861780);
phonebook.Add("Zoran", 077888555);
phonebook.Add("Sanja", 078965324);
phonebook.Add("Ivan", 078432565);
phonebook.Add("Angel", 078223546);

Console.WriteLine("Please add a name");
string addName = Console.ReadLine();

bool adNameExist = phonebook.ContainsKey(addName);
if (adNameExist)
{
    Console.WriteLine($"the number for {addName} is {phonebook[addName]}");
}
