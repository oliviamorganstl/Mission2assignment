using System;

namespace Mission2assignment
{
    public class Program //add comments!
    {
        public static void Main(string[] args)
        {//Setting up variables and get user input
            CounterTool ct = new CounterTool();
            int UserRoll;
            Console.WriteLine("Please enter how many times you would like to simulate rolling the dice");
            UserRoll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("# of rolls ");
            //Go to the class
            ct.getResults(UserRoll); //have two dice

        }
    }
}
