﻿using System;

namespace Ordtæller
{
    class Program
    {
        static void Main(string[] args)
        {
            int ord = 0;
            string x;

            Console.WriteLine("Skriv din tekst/ord");
            x = Console.ReadLine();

                    for(int i = 0; i < x.Length-1; i++) {  
            if(x[i] == ' ' && Char.IsLetter(x[i+1]) && (i > 0)) {  
                ord++; 
            }
                    }
                    ord++;
                            Console.WriteLine("Du har skrevet: " + ord + " antal ord");   


        }
    }
}
