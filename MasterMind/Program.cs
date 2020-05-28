using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        const int iMaxGuesses = 10;
        const int iListSize = 4;
        static void Main(string[] args)
        {
            Random myRandom = new Random();

            // integer list
            List<int> numbers = new List<int>();
            int guesses = 1;

            string result = string.Empty;

            // user's guess
            string strGuess;

            
            int guess;

            // Generate random list of numbers between 1 and 6
            for (int i = 0; i < iListSize; i++)
                numbers.Add(myRandom.Next(1, 7));
               
            // Prompt user to input number
            Console.WriteLine("Guess the {0} Digit code, Under {1} tries!", iListSize, iMaxGuesses);
                       
            do
            {
                    strGuess = Console.ReadLine();
                    if (strGuess.Length != 4 )

                    {
                        Console.WriteLine("Enter a 4 digit number with numbers between 1 and 6");

                    }
                    else
                    {
                        string arrOne = numbers[0].ToString();
                        string arrTwo = numbers[1].ToString();
                        string arrThree = numbers[2].ToString();
                        string arrFour = numbers[3].ToString();
                        string strOne = strGuess[0].ToString();
                        string strTwo = strGuess[1].ToString();
                        string strThree = strGuess[2].ToString();
                        string strFour = strGuess[3].ToString();
                        string numberGuess = strOne + strTwo + strThree + strFour;
                        string randomArray = arrOne + arrTwo + arrThree + arrFour;
 
                        

                        if (numberGuess == randomArray)
                        {
                            Console.WriteLine("Correct! It took {0} guesses to come up with the pattern {1}", guesses, randomArray);
                            Console.WriteLine("Press any key to exit");
                            Console.ReadKey();
                            Environment.Exit(0);
                           
                        }
                        // Confirm input is an integer
                        if (int.TryParse(strGuess, out guess))
                        {
                            
                         
                            guesses++;
 

                            if (numbers[0].ToString() == strOne)
                            {
                           
                                Console.Write("+");
                                     

                            }
                            else if (numbers.Contains(int.Parse(strOne)))
                            {
                                Console.Write("-");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            result += guess;

                            if (numbers[1].ToString() == strTwo)
                            {
                                Console.Write("+");
                                                          }
                            else if (numbers.Contains(int.Parse(strTwo)))
                            {
                                Console.Write("-");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
 
                            result += guess;

                            if (numbers[2].ToString() == strThree)
                            {
                                Console.Write("+");
                                result += guess;
                            }
                            else if (numbers.Contains(int.Parse(strThree)))
                            {
                                Console.Write("-");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            if (numbers[3].ToString() == strFour)
                            {
                                Console.WriteLine("+");
                                result += guess;
                            }
                            else if (numbers.Contains(int.Parse(strFour)))
                            {
                                Console.WriteLine("-");
                            }
                            else
                            {
                                Console.WriteLine(" ");
                            }
                            Console.WriteLine("Try Again, Try #" + guesses);
                        }

                        else 
                        {
                            Console.WriteLine("That was not a number.  Please try again!");
                        }
                    }
               }
                while (guesses <= iMaxGuesses && numbers.Count > 0 ) ;
            
                if (guesses > iMaxGuesses)
            
                    Console.WriteLine(" Sorry you have reached the total allowable guesses of: {0}", (guesses -1));

                Console.ReadLine();
            }
         }
      }
     