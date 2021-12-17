using System;

namespace Small_Bank
{
    struct Person
    {
        public string name;
        public int age;
        public float money;
    }
    
    class Program
    {
        static Person [] member = new Person[2];
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
            Console.WriteLine("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Choise(x);
        }

        static void Choise(int num)
        {
            switch (num)
            {
                case 1:
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
            Console.WriteLine("Enter the name");
            member[i] = new Person();
            member[i].name = Console.ReadLine();
            i++;
            ShowItems();
        }

        static void ShowAllMembers()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var item in member)
            {
                Console.WriteLine(item.name);
            }
            Console.ResetColor();
        }

    }
}
