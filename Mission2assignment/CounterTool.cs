using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2assignment
{
    public class CounterTool
    {
        public void getResults (int numrolls)
        { 
            Random rnd = new Random();
            //int roll;
            int[] numbers = new int[13];
//This loop generates a two random numbers
            for (int i = 0; i < numrolls; i++)
            {
                //roll = rnd.Next(0, 7);//returns random integers < 7
                numbers[((rnd.Next(1, 7)) + (rnd.Next(1, 7)))]++;
            }
//This loop sets up the array with the corresponding number rolled
            for (int i = 2; i < numbers.Length; i++)
            {
                int numSymbol = 0;
                numSymbol = (int)(i);
                string asterisks = "";
                float onepercentvalue = ((float)numbers[i] / (float)numrolls) * 100; //this one percent thing is annoying
//This loop provides the histogram looking asterisks next to it based off the percentage of rolls
                for (int counter=0; counter < (int) onepercentvalue; counter++)
                {
                    asterisks = asterisks + "*";
                }
                Console.WriteLine(numSymbol + ": " + asterisks);

            }
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each * represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls: " + numrolls);
        }
    }
}
