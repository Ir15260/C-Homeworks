//Make a new console application called StudentGroup

//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.

//Get a number from the console between 1 and 2 and print the students from that group in the console.

//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]

//Test Data:

//Enter student group: (there are 1 and 2 )
//1
//Expected Output:

//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko


string[] studentsG1 = new string[5];
studentsG1[0] = "Zoran";
studentsG1[1] = "Goran";
studentsG1[2] = "Borjan";
studentsG1[3] = "Stojan";
studentsG1[4] = "Trajan";

string[] studentsG2 = new string[5];
studentsG2[0] = "Aleksandar";
studentsG2[1] = "Filip";
studentsG2[2] = "Sanja";
studentsG2[3] = "Dina";
studentsG2[4] = "Mina";



Console.WriteLine("Please enter the 1 or 2");
string numberOfArray = Console.ReadLine();
int number;
bool parsingResult = int.TryParse(numberOfArray, out number);


if (parsingResult)
{
    if (number == 1)
    {
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    }
    else if (number == 2)
    {
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
    else
    {
        Console.WriteLine("Invalid input - please add 1 or 2");
    }
}
else
{
    Console.WriteLine("Invalid input you must enter a number");
}