using System;
using System.Collections.Generic;
namespace Small_Bank
{
    // struct Person
    // {
    //     public string name;
    //     public int age;
    //     public float money;
    // }
    
    class Program
    {
        static int [] ar;

        // static Person [] member = new Person[100];
        public static List <User> listOfUser = new List<User>();
        static int i =0;
        static void Main(string[] args)
        {
           
            ShowItems();
        }

        static void ShowItems()
        {
            Console.WriteLine("1- Create new account");
            Console.WriteLine("2- Update account");
            Console.WriteLine("3- Create new account");
            Console.WriteLine("4- Transactions");
            Console.WriteLine("5- Remove account");
            Console.WriteLine("6- Show all persons");
            Console.Write("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Choise(x);
        }

        static void Choise(int num)
        {
            switch (num)
            {
                case 1:
                Console.Clear();
                CreatePerson();

                break;
                case 2:
                break;
                case 3:

                break;
                case 4:

                break;
                case 5:

                break;
                case 6:
                ShowAllMembers();
                break;            
                default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; //set red color
                Console.WriteLine("Your number isn't exist Try again");
                Console.ResetColor(); // remove red color
                ShowItems();
                break;
            }
        }

        static void CreatePerson()
        {
            Console.Clear();
            Console.Write("Enter the name:  ");
            string name = Console.ReadLine();
            Console.Write("Enter the Age:  ");
            int age = Convert.ToInt32(Console.ReadLine());
            listOfUser.Add(new User(name,age));
            ShowItems();
        }

        static void ShowAllMembers()
        {
            Console.Clear();
            Console.WriteLine("1- Age order");
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                Alphabeticalorder();
                break;
                default:
                Console.ForegroundColor = ConsoleColor.Red; //set red color
                Console.WriteLine("Your number isn't exist Try again");
                Console.ResetColor(); // remove red color
                ShowAllMembers();
                break;
            }
            // Console.ForegroundColor = ConsoleColor.Blue;
            // foreach (var item in listOfUser)
            // {
            //     Console.WriteLine(item.Name);
            // }
            // Console.ResetColor();
        }

        static void Alphabeticalorder()
        {
        HeapSort ob = new HeapSort();
        List<int> ages = new List<int>();
        List<string> names = new List<string>();
        foreach (var item in listOfUser)
        {
            ages.Add(item.Age);
            names.Add(item.Name);
        }
        ob.sort(ages, names);
        ob.printArray(ages, names);
        }


    }
}
