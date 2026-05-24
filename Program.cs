using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // First JSON file
            string userFile = "user.json";

            string userResponse =
                File.ReadAllText(userFile);

            List<User> users =
                JsonConvert.DeserializeObject<List<User>>(userResponse);

            Console.WriteLine("Users:");

            foreach (User user in users)
            {
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Age: {user.Age}");
                Console.WriteLine($"City: {user.City}");
                Console.WriteLine();
            }


            // Second JSON file
            string typeFile = "user_types.json";

            string typeResponse =
                File.ReadAllText(typeFile);

            List<UserType> userTypes =
                JsonConvert.DeserializeObject<List<UserType>>(typeResponse);

            Console.WriteLine("User Types:");

            foreach (UserType type in userTypes)
            {
                Console.WriteLine($"Name: {type.Name}");
                Console.WriteLine($"Access: {type.AccessLevel}");
                Console.WriteLine();
            }
        }
    }
}