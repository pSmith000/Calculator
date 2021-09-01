using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        string value1;
        string value2;
        System.Globalization.NumberStyles style;
        System.Globalization.CultureInfo culture;
        float number1;
        float number2;

        float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        float Calculate(string description, string add, string subtract, string multiply, string divide)
        {
            float answer = 0;
            int invalidInput = 0;

            Console.WriteLine(description);

            //Converting strings to floats

            while (!(invalidInput == 1))
            {
                Console.Write("First Number: ");
                value1 = Console.ReadLine();

                style = System.Globalization.NumberStyles.Number |
                System.Globalization.NumberStyles.AllowCurrencySymbol;
                culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
                if (Single.TryParse(value1, style, culture, out number1))
                {
                    invalidInput = 1;
                }
                else
                {
                    Console.WriteLine("invalid input");
                    Console.WriteLine("press ENTER to continue");
                    Console.ReadKey();
                    Console.Clear();
                    invalidInput = 0;
                }
            }

            invalidInput = 0;


            while (!(invalidInput == 1))
            {
                Console.Write("Second Number: ");
                value2 = Console.ReadLine();

                style = System.Globalization.NumberStyles.Number |
                System.Globalization.NumberStyles.AllowCurrencySymbol;
                culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");
                if (Single.TryParse(value2, style, culture, out number2))
                {
                    invalidInput = 1;
                }
                else
                {
                    Console.WriteLine("invalid input");
                    Console.WriteLine("press ENTER to continue");
                    Console.ReadKey();
                    Console.Clear();
                    invalidInput = 0;
                }
            }

            invalidInput = 0;


            while (!(invalidInput == 1 ))
            {
                Console.WriteLine("\n1. " + add);
                Console.WriteLine("2. " + subtract);
                Console.WriteLine("3. " + multiply);
                Console.WriteLine("4. " + divide);
                Console.Write("> ");

                string input = Console.ReadLine();

                if (input == "1" || input == add)
                {
                    answer = Add(number1, number2);
                    invalidInput = 1;
                }
                else if (input == "2" || input == subtract)
                {
                    answer = Subtract(number1, number2);
                    invalidInput = 1;
                }
                else if (input == "3" || input == multiply)
                {
                    answer = Multiply(number1, number2);
                    invalidInput = 1;
                }
                else if (input == "4" || input == divide)
                {
                    answer = Divide(number1, number2);
                    invalidInput = 1;
                }
                else
                {
                    Console.WriteLine("invalid input");
                    Console.WriteLine("press enter to continue");
                    Console.ReadKey();
                    Console.Clear();
                    invalidInput = 0;
                }
            }

            return answer;
        }
        public void Run()
        {
            bool gameOver = false;
            int invalidInput = 0;
            while (gameOver == false)
            {
                invalidInput = 0;
                float answer;

                answer = Calculate("Please enter two numbers.", "add", "subtract", "multiply", "divide");

                Console.WriteLine("Your answer is " + answer);


                while (!(invalidInput == 1))
                {
                    Console.Write("\nWould you like to calculate more numbers? \n1. Yes\n2. No\n> ");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        invalidInput = 1;
                    }

                    else if (input == "2")
                    {
                        gameOver = true;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("invalid input");
                        invalidInput = 0;
                    }
                }

                Console.WriteLine("\nPress ENTER to continue");
                Console.ReadKey();
                Console.Clear();
            }
                



        }
    }
}
