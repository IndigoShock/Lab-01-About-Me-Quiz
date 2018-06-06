using System;

namespace Class02Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TryBlockExample();
        }
    
        static void TryBlockExample()
        {
            string number = "twenty";
        try
        {
            int twenty = Convert.ToInt32(number);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"{number} is not an integer");
            Console.WriteLine(e.Message);

        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("This is an exception for Null references.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("This is an exception.");
        }
        }
        static void CatchSingleException()
        {
            int milesDriven, gallonsOfGas, mpg;

            try
            {
                Console.WriteLine("Enter Miles Driven: ");
                milesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter gallons of gas purchased: ");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());

                mpg = milesDriven / gallonsOfGas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static string FizzBuzz(int number)
        {
            if((number % 3 == 0) && (number % 5 == 0))
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }
    }
}
