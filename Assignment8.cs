
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assinment8
{
    public class Exhaustion
    {
        public static void Main(string[] args)
        {
            string number = "0", guess = "";
            int primeNumbers = 0;
            
            while(number != "q")
            {

                Console.WriteLine("Enter a number, to guess how many prime numbers are between 0 and the number entered: (or enter q to quit)");
                StringCheck(out number);
                
                Console.WriteLine("Guess how many prime numbers there between 0 and " + number + ": ");
                StringCheck(out guess);
                
                PrimeNumber(ref number,ref guess,out primeNumbers);
                
                if(primeNumbers == int.Parse(guess))
                    Console.WriteLine("Your Guess of " + guess + " is correct! there are " + primeNumbers + " prime numbers between 0 and " + number);
                else
                    Console.WriteLine("Your Guess of " + guess + " is wrong. there are " + primeNumbers + " prime numbers between 0 and " + number);
                
                
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        private static void StringCheck(out string input)
        {   
            input = Console.ReadLine();
            
            if(input == "q") Environment.Exit(0);
            
            while(!int.TryParse(input))
            {
                Console.WriteLine("Error, incorrect entry: ");
                input = Console.ReadLine();
            }
        }
    
        private static void PrimeNumber(ref string number,ref string guess,out int primeNumbers)
        {
            bool isPrime = false;
            for(int i = 0;i < int.Parse(number); i++ )
            {
                for(int j = 0; j < i; j++)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else 
                        isPrime = true;
                }
                if(isPrime)
                    primeNumbers++;
            }
        }
    }
}
