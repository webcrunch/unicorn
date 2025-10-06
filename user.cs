namespace App
{
    using System.Collections.Generic;

    // Class to represent a user
    public class User
    {
        public string Username;
        public string Password;
        public List<Item> MyItems;        // User can have many items
        public List<Trade> MyTrades;
    }
}