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
        static string step;
        static LinkedList<String> transition = new LinkedList<String>();
        
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
            Console.WriteLine("3- Show all persons");
            Console.WriteLine("4- Delete accont");
            Console.WriteLine("5- Transactions");
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
                Console.Clear();
                LogIn();
                break;
                case 3:
                ShowAllMembers();

                break;
                case 4:
                Console.Clear();
                DeleteAccont();
                break;
                case 5:
                ShowTransition();

                break;
                case 6:
                break;            
                default:
                Error();
                ShowItems();
                break;
            }
        }

        static void CreatePerson()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Create Accont: ");
            Console.ResetColor();
            Console.Write("Enter the name:  ");
            string name = Console.ReadLine().ToLower();
            Console.Write("Enter the Age:  ");
            string age = Console.ReadLine();
            Console.Write("Enter the PassWord:  ");
            string num = Console.ReadLine();
            int pass, Age;
            if ((int)num[0] > 47 && (int)num[0] < 58 && (int)age[0] > 47 && (int)age[0] < 58)
            {
                pass = Convert.ToInt32(num);
                Age = Convert.ToInt32(age);
                BST.insert(BST.root, pass, name); //Use Binary tree
                listOfUser.Add(new User(name,Age,pass));
                Console.Clear();
                ShowItems();                
            }
            else
            {
                Z:
                Error();
                    Console.WriteLine("If you want come back enter Q: ");
                    Console.WriteLine("If you want come try again enter R: ");
                    step = Console.ReadLine().ToLower();
                    if (step == "q")
                    {
                        Console.Clear();
                        ShowItems();
                    }
                    else if (step == "r")
                    {
                        Console.Clear();
                        CreatePerson();
                    }
                    else
                    {  
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter the correct word");
                        Console.ResetColor();
                        goto Z;
                    
                    }                  
            }

        }


        static void DeleteAccont()
        {
            // Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Delete Accont: ");
            Console.ResetColor();
            Console.Write("Enter the name:  ");
            string name = Console.ReadLine().ToLower();
            Console.Write("Enter the PassWord:  ");
            string num = Console.ReadLine();
            int pass;
            if ((int)num[0] > 47 && (int)num[0] < 58)
            {
                pass = Convert.ToInt32(num);
                if (BST.ifNodeExists(BST.root, pass, name))
                {
                    Console.Clear();
                    foreach (var item in listOfUser)
                    {
                        if (item.Name == name)
                        {
                            item.Name = null;
                            item.Pass = 0;
                            item.Age = 0;
                        }
                    }                              
                    BST.deleteKey(pass,name);

                    show:
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("Dear " + name + "your accont were deleted");
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
                            goto show;
                        }
                }
                else
                {
                U :                
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It does'nt exist or your password or your name is'nt correct");
                    Console.ResetColor();
                    Console.WriteLine("If you want come back enter Q: ");
                    Console.WriteLine("If you want come try again enter R: ");
                    step = Console.ReadLine().ToLower();
                    if (step == "q")
                    {
                        Console.Clear();
                        ShowItems();
                    }
                    else if (step == "r")
                    {
                        DeleteAccont();
                    }
                    else
                    {  
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter the correct word");
                        Console.ResetColor();
                        goto U;
                    
                    }            
                }
            }
            else
            {
                Error();
                DeleteAccont();
            }
            
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
        }

        static void Ageorder() // Use Heap sort
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
                S:
                ob.sort(ages, names);
                ob.printArray(ages, names);
                Console.ReadLine();
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
                    goto S;
                }
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

        static void LogIn() //Use Binary tree
        {
            // Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Login: ");
            Console.ResetColor();
            Console.WriteLine("Enter The Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The PassWord: ");
            string num = Console.ReadLine();
            int key;
            Console.Clear(); 
            if ((int)num[0] > 47 && (int)num[0] < 58)
            {
                key = Convert.ToInt32(num);
                if(BST.ifNodeExists(BST.root, key, name))
                {
                    tra:
                    Console.WriteLine("Welcome " + name);
                    Console.Write("If you want to make a financial transaction enter 1:  ");
                    switch (Convert.ToUInt32(Console.ReadLine()))
                    {
                        case 1:
                        FinancialTransaction(name);
                        break;
                        
                        default:
                        Console.Clear();
                        Error();
                        goto tra;
                        // break;
                    }
                
                }
                else
                {
                D :                
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It does'nt exist or your password or your name is'nt correct");
                    Console.ResetColor();
                    Console.WriteLine("If you want come back enter Q: ");
                    Console.WriteLine("If you want come try again enter R: ");
                    step = Console.ReadLine().ToLower();
                    if (step == "q")
                    {
                        Console.Clear();
                        ShowItems();
                    }
                    else if (step == "r")
                    {
                        LogIn();
                    }
                    else
                    {  
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter the correct word");
                        Console.ResetColor();
                        goto D;
                    }                      
                }

            
            }
            else
            {
                T:
                Error();
                    Console.WriteLine("If you want come back enter Q: ");
                    Console.WriteLine("If you want come try again enter R: ");
                    step = Console.ReadLine().ToLower();
                    if (step == "q")
                    {
                        Console.Clear();
                        ShowItems();
                    }
                    else if (step == "r")
                    {
                        Console.Clear();
                        LogIn();
                    }
                    else
                    {  
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter the correct word");
                        Console.ResetColor();
                        goto T;
                    
                    }               
            }           


        }

        static List<string> CollectNames()
        {
            List<string> names = new List<string>();
            foreach (var item in listOfUser)
                names.Add(item.Name);
            return names;
        }

        static void FinancialTransaction(string name) // Use LinkedList
        {
            Console.WriteLine("Enter the amount: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string amount = Console.ReadLine();
            Console.ResetColor();
            transition.AddLast(name + " made a transaction for " + amount + " $ at " + DateTime.Now);
            Console.Clear();
            ShowItems();
        }

        static void Error()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red; //set red color
            Console.WriteLine("Some of your inputs isn't number Try again");
            Console.ResetColor(); // remove red color
        }

        static void ShowTransition() // Use LinkedList
        {
            C:
                if (transition.Count > 0)
                { 
                    foreach(string str in transition)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(str);
                        Console.ResetColor();
                        
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
                            goto C;
                        }
                }

                else
                {
                    W:
                    Console.ForegroundColor = ConsoleColor.Red;
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
                            goto W;
                        }
                }

        }


    }
}
