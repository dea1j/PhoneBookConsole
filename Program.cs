using System;

namespace PhoneBookConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to console Phonebook");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1-> Add Contact");
            Console.WriteLine("2-> Display Contact By Number");
            Console.WriteLine("3-> View All Contacts");
            Console.WriteLine("4-> Search Contact By Name");
            Console.WriteLine("x-> Exit Program");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Select contact to search");
                        var searchNumber = Console.ReadLine();

                        phoneBook.DisplayContact(searchNumber);

                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Enter contact name");
                        var searchPhrase = Console.ReadLine();

                        phoneBook.DisplayMatchingContact(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }

                Console.WriteLine("Select operation");
                userInput = Console.ReadLine();
            }

        }
    }
}