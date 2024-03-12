//Create a class User with the following:

//Id - int
//Username - string
//Password - string
//Messages - Array of strings
//Create an array of users and add 3 users to it manually ( hard-coded ).

//Create a Console UI that will give the user two options to choose from:

//Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:
//Message1
//Message2
//If not found, it should print an error message
//Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
//Registration complete! Users:
//23 Username1
//44 Username2
//1 Username3
//56 Username4**

using Exercise1;
using System;

User[] users = new User[]
 {
new User(66585, "IRq5260", "IlijaR"),
new User(66585, "Ivan222", "Ivan123"),
new User(12345, "Aleksandar222", "academy123"),
new User(22233, "Pane2334", "academy123"),
};

Console.WriteLine("1. Log in");
Console.WriteLine("2. Register");
Console.WriteLine("Please choose an option");

int insertNumber;
while (true)
{
    Console.WriteLine("Please select use 1 or 2");
    string addNumber = Console.ReadLine();
    bool insertNumber1 = int.TryParse(addNumber, out insertNumber);
    if (!insertNumber1 || (insertNumber != 1 && insertNumber != 2))
    {
        Console.WriteLine("Please add 1 or 2");
    }
    else if (insertNumber == 1)
    {

        LogIN();
        break;

    }
    else if (insertNumber == 2)
    {
        AddInfo();
        break;
    }
}


void LogIN()
{
    Console.WriteLine("Please enter a username to search for");
    string inputUserName = Console.ReadLine();

    Console.WriteLine("Please enter a password to search for");
    string inputUserPassword = Console.ReadLine();
    User foundUser = FindUsers(users, inputUserName, inputUserPassword);
    while (true)
    {

        if (foundUser != null)
        {

            foundUser.PrintInfo();
        }
        else if (foundUser == null)
        {
            Console.WriteLine("Please add username and pass");
        }

        {
            break;
        }
    }

    User FindUsers(User[] usersArray, string inputUserName, string inputUserPassword)
    {
        foreach (User user in usersArray)
        {
            if (inputUserName == user.Username && inputUserPassword == user.Password)
            {
                return user;
            }
        }

        return null;
    }
}

void AddInfo()
{
    string newUserName;

    while (true)
    {
        Console.WriteLine("Add Username");
        string addUserName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(addUserName))
        {
            Console.WriteLine("Invalid input. Username cannot be empty.");
        }
        else
        {
            newUserName = addUserName;
            break;
        }
    }

    string newPassword;

    while (true)
    {
        Console.WriteLine("Add Password");
        string addPassword = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(addPassword))
        {
            Console.WriteLine("Invalid input. Password cannot be empty.");
        }
        else
        {
            newPassword = addPassword;
            break;
        }
    }

    int newId;

    while (true)
    {
        Console.WriteLine("Add 5-digit ID");
        string idInput = Console.ReadLine();

        if (int.TryParse(idInput, out newId) && idInput.Length == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid 5-digit integer.");
        }
    }

    User user = new User(newId, newUserName, newPassword);
    Array.Resize(ref users, users.Length + 1);
    users[users.Length - 1] = user;

    Console.WriteLine("User added successfully!");


    Console.WriteLine("Do you want to");
    Console.WriteLine("1. Log in");
    Console.WriteLine("2. Register");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Please select use 1 or 2 or 3");
    int insertNumber2;
    string addNumber2 = Console.ReadLine();
    bool insertNumber2check = int.TryParse(addNumber2, out insertNumber2);

    if (!insertNumber2check || (insertNumber2 != 1 && insertNumber2 != 2 && insertNumber2 != 3))
    {
        Console.WriteLine("Please add 1 or 2 or 3");
    }
    else
    {
        switch (insertNumber2)
        {
            case 1:
                LogIN();
                break;
            case 2:
                AddInfo();
                break;
            case 3:
                Console.WriteLine("Exiting program.");
                return;
            default:
                Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                break;
        }
    }
    {

    }

}
