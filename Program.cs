using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number;
            string letter;
            double grade;
            char character;

            //1. Am I Positive
            Console.Write("Please enter an integer: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive number");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative number");
            }
            else
            {
                Console.WriteLine($"{number} is neither negative or positive");
            }

            //2. Vowels
            Console.Write("Please enter a letter: ");
            letter = Console.ReadLine();

            if (letter == "A" || letter == "a" || letter == "E" || letter == "e" || letter == "I" || letter == "i" || letter == "O" || letter == "o" || letter == "U" || letter == "u")
            {
                Console.WriteLine($"{letter} is a vowel");
            }
            else
            {
                Console.WriteLine($"{letter} is not a vowel");
            }

            //2. Vowels but with To.lower
            Console.Write("Please enter a letter: ");
            letter = Console.ReadLine();
            letter = letter.ToLower();

            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine($"{letter} is a vowel");
            }
            else
            {
                Console.WriteLine($"{letter} is not a vowel");
            }

            //3. Letter Grade
            Console.Write("Please enter a numeric grade: ");
            grade = Convert.ToDouble(Console.ReadLine());

            if (grade < 50)
            {
                Console.WriteLine($"{grade}% = F");
            }
            else if (grade >= 50 && grade <= 59)
            {
                Console.WriteLine($"{grade}% = D");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine($"{grade}% = C");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine($"{grade}% = B");
            }
            else
            {
                Console.WriteLine($"{grade}% = A");
            }

            //4. Vowels but with switch statement
            Console.Write("Please enter a letter: ");
            letter = Console.ReadLine();

            switch (letter)
            {
                case "A":
                case "a":
                case "E":
                case "e":
                case "I":
                case "i":
                case "O":
                case "o":
                case "U":
                case "u":
                    Console.WriteLine($"{letter} is a vowel");
                    break;
                default:
                    Console.WriteLine($"{letter} is not a vowel");
                    break;
            }

            //4 enrichment
            
            Console.Write("Please enter a character: ");
            character = Convert.ToChar(Console.ReadLine());

            if ((character >= 'A' && character <= 'Z') || (character >= 'a' && character <= 'z'))
            { 
            switch (character)
                {
                    case 'A':
                    case 'a':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'O':
                    case 'o':
                    case 'U':
                    case 'u':
                        Console.WriteLine($"{character} is a vowel");
                        break;
                    default:
                        Console.WriteLine($"{character} is not a vowel");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Enter alphabet only!");
            }
               
                Console.ReadKey();
        }
    }
}
