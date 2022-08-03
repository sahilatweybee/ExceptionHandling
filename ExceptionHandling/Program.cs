using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class UnderAgeException : Exception
    {
        public UnderAgeException(String message)
            : base(message)
        {
            HelpLink = "docs.microsoft.com";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch (ArithmeticException e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("\nCan't devide a number with 0 (Zero)!!"); }
            // finally { Console.WriteLine("Completed...\n"); } can't use multiple finally blocks
            Console.ReadLine();

            try 
            {
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new UnderAgeException("Sorry, Age must be greater than 18");
                }
                else
                {
                    Console.WriteLine("You are Eligible to have Driving Licence");
                }
            }
            catch (UnderAgeException e) { Console.WriteLine($"{e} \n{e.HelpLink}"); }
            catch (FormatException e) { Console.WriteLine(e); }

            // unchecked // Default is unchecked
            {
                Console.WriteLine(" ");
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }

            // this will give an type overflow exception
            //checked
            //{
            //    Console.WriteLine(" ");
            //    int val = int.MaxValue;
            //    Console.WriteLine(val + 2);
            //}

            Console.ReadLine();
        }
    }
}
