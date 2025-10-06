namespace App
{
    using System.Collections.Generic;

    // Class to represent a user
    public class User
    {
        public string Username;
        public string Password;
        public List<Item> MyItems;        // User can have many items
        public List<Trade> MyTrades;      // Trades involving this user

        // Constructor to initialize user
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            MyItems = new List<Item>();
            MyTrades = new List<Trade>();
        }

        public void AddItem(Item item)
        {
            MyItems.Add(item);
        }

        // Display all items of user
        // Check login credentials
        public bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
    

  