using System.Text.RegularExpressions;

namespace Exercise1
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        



     
        public User(int id, string username, string password)
        {
            ID = id;
            Username = username;
            Password = password;
           
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Here is your ID: {ID}");

        }
    }
}



    