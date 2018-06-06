using System;

namespace Lab01AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //int counter = 0;
            Console.WriteLine("Hello! This is my About Me quiz. First, what's my nickname?");
            NameQuestion();
            Console.WriteLine("How many cats do I have? (Numbers only please)");
            CatQuestion();
            Console.WriteLine("Do I perform improv? True/false");
            ImprovQuestion();
            Console.WriteLine("What day of the week do I volunteer for Crisis Clinic?");
            CrisisQuestion();
            Console.WriteLine("Is cheesecake my most favoritest dessert? True/False again");
            CheesecakeQuestion();
            //Console.WriteLine($"You got {counter} correct!");
            Console.ReadLine();
        }

        public static string NameQuestion()
        {
            string userValue = Console.ReadLine().ToLower();
            if (userValue == "steph")
            {
                Console.WriteLine("Correct!");
                //counter++;
            }
            else
            {
                Console.WriteLine("Mm...no");
            }
            return userValue;
        }

        private static int CatQuestion()
        {
            string userValue = Console.ReadLine();
            int value;
            if (int.TryParse(userValue, out value))
            {
                Console.WriteLine("Unfortunately, yes. I have 0 cats.");
                //counter++;
                return value;
            }
            else
            {
                Console.WriteLine("I wish!");
                return value;
            }
        }

        public static bool ImprovQuestion()
        {
            string userValue = Console.ReadLine().ToLower();

            if (userValue == "true")
            {
                Console.WriteLine("Yes! I perform with my group, Half Sister");
                //counter++;
                return true;
            }
            else
            {
                Console.WriteLine("Hm...not quite.");
                return false;
            }
        }

        public static string CrisisQuestion()
        {
            string userValue = Console.ReadLine().ToLower();
            if (userValue == "friday")
            {
                Console.WriteLine("Yes! Friday's are long like longcat.");
                //counter++;
            }
            else
            {
                Console.WriteLine("Erm...no");
            }
            return userValue;
        }

        public static bool CheesecakeQuestion()
        {
            string userValue = Console.ReadLine().ToLower();

            if (userValue == "true")
            {
                Console.WriteLine("Definitely the most favoritest. Especially with raspberries.");
                //counter++;
                return true;
            }
            else
            {
                Console.WriteLine("Hm...gonna have to say if you put anything else besides true, you will be wrong.");
                return false;
            }
        }
    }
}
