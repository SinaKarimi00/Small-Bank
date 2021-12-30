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
            Console.WriteLine("2- Log In");
            // Console.WriteLine("3- Update account");
            // Console.WriteLine("4- Create new account");
            Console.WriteLine("3- Transactions");
            Console.WriteLine("4- Show all persons");
            // Console.WriteLine("5- Show all persons");
            Console.Write("Enter the number: ");
            string num = Console.ReadLine();
            if ((int)num[0] > 47 && (int)num[0] < 58)
            {
                Choise(Convert.ToInt32(num));
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red; //set red color
                Console.WriteLine("Your number isn't exist Try again");
                Console.ResetColor(); // remove red color
                ShowItems();
            }

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
                    LogIn();
                break;
                case 3:

                break;
                case 4:
                ShowAllMembers();

                break;
                case 5:


                break;
                case 6:
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
            string name = Console.ReadLine().ToLower();
            Console.Write("Enter the Age:  ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the PassWord:  ");
            int pass = Convert.ToInt32(Console.ReadLine());
            GFG.insert(GFG.root, pass, name);
            listOfUser.Add(new User(name,age,pass));
            Console.Clear();
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
                Ageorder();
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

        static void Ageorder()
        {
        HeapSort ob = new HeapSort();
        List<int> ages = new List<int>();
        List<string> names = new List<string>();
        foreach (var item in listOfUser)
        {
            ages.Add(item.Age);
            names.Add(item.Name);
        }
        R:
            if (listOfUser.Count > 0)
            {
                ob.sort(ages, names);
                ob.printArray(ages, names);
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("List is empty");
                Console.ResetColor();
                
                Console.WriteLine("If you want come back enter Q: ");
                if (Console.ReadLine().ToLower() == "q")
                {
                    Console.Clear();
                    ShowItems();
                }
                
                else
                {  
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter the correct word");
                    Console.ResetColor();
                    goto R;
                }
        }
        }

        static void LogIn()
        {
            Console.Clear();
            Console.WriteLine("Enter The Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The PassWord: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            show : 
            if(GFG.ifNodeExists(GFG.root, key, name))
            {
                Console.WriteLine("Welcome " + GFG.root.name);
            }
            Console.WriteLine("If you want come back enter Q: ");
            if (Console.ReadLine().ToLower() == "q")
            {
                Console.Clear();
                ShowItems();
            }
            
            else
            {  
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter the correct word");
                Console.ResetColor();
                goto show;
            }
        }

        static List<string> CollectNames()
        {
            List<string> names = new List<string>();
            foreach (var item in listOfUser)
                names.Add(item.Name);
            return names;
        }


    }
}
