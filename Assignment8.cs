
uusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;  

namespace Assinment8 
{  
    public class Exhaustion 
    {     
        private static int primeNumbers = 0;
        
        private static string input = ""; 
        
        public static void Main(string[] args)
        {       
            int number = 0, guess = 0;            
            
            while(input != "q")       
            {                  
                Console.WriteLine("Enter a number: (or enter q to quit)");         
                number = InputCheck();
                
                Console.WriteLine("Now guess how many prime numbers there between 0 and " + number + ": ");         
                guess = InputCheck();                
                
                PrimeNumber(ref number);                
                if(primeNumbers == guess)  
                    Console.WriteLine("Your Guess of " + guess + " is correct! there are " + primeNumbers + " prime numbers between 0 and " + number);         
                else          
                    Console.WriteLine("Your Guess of " + guess + " is wrong. there are " + primeNumbers + " prime numbers between 0 and " + number + "\n");                 
                primeNumbers = 0;      
            }     
        }    
        
        private static int InputCheck()    
        {          
            int num;            
            
            input = Console.ReadLine();            
            if(input == "q") Environment.Exit(0);             
            while(!int.TryParse(input,out num))       
            {         
                Console.WriteLine("Error, incorrect entry: ");         
                input = Console.ReadLine();       
            }             
            return num;    
        }         
        
        private static void PrimeNumber(ref int number)     
        {       
            bool isPrime = true;             
            for(int i = 2;i < number; i++ )       
            {         
                for(int j = 2; j < i; j++)        
                { 
                    if((i % j) == 0) 
                     }             
                        isPrime = false;            
                        break;           
                     }          
                    else             
                        isPrime = true;         
                }         
                if(isPrime)         
                {          
                    primeNumbers += 1;           
                    Console.WriteLine(i);       
                }      
            }     
        }   
    } 
} 

