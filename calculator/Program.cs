using System;
using System.Globalization;

//#nullable enable

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ask_number_one();
        }

        private static void ask_number_one()
        {
<<<<<<< HEAD
            Console.Write("Enter the first number >> ");
			string? input = null;
			input = Console.ReadLine();
=======
            Console.Write("Enter any number >> ");
            string input = Console.ReadLine();
>>>>>>> refs/remotes/origin/main
			
			if (input?.Length!=0 && float.TryParse(input, out float number))
			{
				ask_number_two(number);
			}
            else
            {
                Console.WriteLine("Emphasis on number.");
                ask_number_one();
            }
			
        }

        private static void ask_number_two(float number_one)
        {
<<<<<<< HEAD
            Console.Write("Enter the second number >> ");
			string? input = null;
			input = Console.ReadLine();
			
            if (!string.IsNullOrEmpty(input) && float.TryParse(input, out float number))
			{
				ask_operation(number_one, number);
			}
            else  
=======
            Console.Write("Enter a second number >> ");
            string input = Console.ReadLine();
            float? number_two = (float.TryParse(input, out float number)) ? number : null;

            if (number_two != null)
            {
                ask_operation(number_one, number_two);
            }
            else 
>>>>>>> refs/remotes/origin/main
            {
                Console.WriteLine("Emphasis on number.");
                ask_number_two(number_one);
            }
        }

        private static void ask_operation(float number_one, float number_two)
        {
            Console.Write("Enter any operator (add, +, sub, -, mul, *, div, /) >> ");
            string input = Console.ReadLine();
            
			switch (input)
			{
                case "add":
                case "+":
                    Console.WriteLine("{0} plus {1} is {2}", number_one, number_two, (number_one + number_two));
                    ask_to_play_again();
                    break;
                case "sub":
                case "-":
                    Console.WriteLine("{0} minus {1} is {2}", number_one, number_two, (number_one - number_two));
                    ask_to_play_again();
                    break;
                case "mul":
                case "*":
                    Console.WriteLine("{0} times {1} is {2}", number_one, number_two, (number_one * number_two));
                    ask_to_play_again();
                    break;
                case "div":
                case "/":
                    Console.WriteLine("{0} over {1} is {2}", number_one, number_two, (number_one / number_two));
                    ask_to_play_again();
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    ask_operation(number_one, number_two);
                    break;
            }
        }

        private static void ask_to_play_again()
        {
            Console.Write("Do you want to play again? (y/n) >> ");
            string input = Console.ReadLine();

			if (input.ToLower() == "y")
			{
				Console.Clear();
				ask_number_one();
			} 
			
			else
			{
				Console.Clear();
			}
        }
    }
}
