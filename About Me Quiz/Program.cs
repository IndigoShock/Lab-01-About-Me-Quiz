using System;

namespace About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {   
            counter = 0;
            Console.WriteLine("Hello! This is my About Me quiz. First, what's my nickname?");
            NameQuestion();
            Console.WriteLine("How many cats do I have? (Numbers only please)");  
            CatQuestion();
            Console.WriteLine("Do I perform improv? True/false Q.");
            ImprovQuestion();
            Console.WriteLine("What day of the week do I volunteer for Crisis Clinic?");
            CrisisQuestion();
            Console.WriteLine("Cheesecake is my most favoritest dessert. True/False Q again.");
            CheesecakeQuestion();
            ShowCounter();
        }

        static string NameQuestion()
        {
            string userValue = Console.ReadLine();
            if (userValue == "steph") 
                {
                    Console.WriteLine("Correct!");
                    counter++;
                }
            else 
                {
                    Console.WriteLine("Mm...no");
                }
        }

        static int CatQuestion()
        {
            int userValue = Console.ReadLine();
            if (userValue == "0") 
                {
                    Console.WriteLine("Unfortunately, yes. I have 0 cats.");
                    counter++;
                }
            else 
                { 
                    Console.WriteLine("I wish!"); 
                }
        }

        static bool ImprovQuestion()
            {
                "true" == true;
            if (true) 
                {
                    Console.WriteLine("Yes! I perform with my group, Half Sister");
                    counter++;
                }
            else 
                {
                    Console.WriteLine("Hm...not quite.");
                }
            }              

        static string CrisisQuestion()
            {
                string userValue = Console.ReadLine();
                if (userValue == "friday") 
                    {
                        Console.WriteLine("Yes! Friday's are long like longcat.");
                    }
                else 
                    {
                        Console.WriteLine("Erm...no");
                    }
            }        
        
        static bool CheesecakeQuestion()
            {
               "true" == true;
            if (true) 
                {
                    Console.WriteLine("Definitely the most favoritest. Especially with raspberries.");
                }
            else 
                {
                    Console.WriteLine("Hm...gonna have to say if you put anything else besides true, you will be wrong.");
                }
            }

        static void ShowCounter() 
            {
                Console.WriteLine($"You got {counter} correct!");
            }
    }
}
