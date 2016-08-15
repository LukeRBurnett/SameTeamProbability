using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Created by Luke Burnett
 * for my 4th year simulation and modeling class
 The goals of the program is to calculate the chance that two people have of being randomly selected to the same team
 given that there are two teams of 5 people. The obvious answer is 50% chance, but here I calculate that
 with a Monte Carlo method
 
*/

namespace Assignment2P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // n is the number of trials
            int n = 100;
            // count tracks the number of times that person 1 and person 2 are on the same team
            int count = 0;
            // tracker keeps track of whether the number of people on one team hit 10 
            int tracker;
            // Creates a new random number
            Random rand = new Random();
            // this for loop will run n times
            for (int i = 0; i < n; i++)
            {
                // the tracker is reset to 0 for the new trial
                tracker = 0; 
                
                // this loop goes through the ten people and gives them 1 or 2 to denote their team
                int[] team = new int[10];
                for (int j = 0; j< 10; j++)
                {
                    // chooses a number that is 1 or 2
                   int choice = rand.Next(1,3);

                    // if the number is 1 or 2, then the current person will be given that team
                   if (choice == 1)
                    {
                        team[j] = 1;
                        //tracker gets lower when more people are on team 1
                        tracker--;
                    }

                   if (choice == 2)
                    {
                        team[j] = 2;
                        //similarly, tracker gets bigger when more people are on team 2
                        tracker++;
                    }
                   // if tracker equals 5 or -5, then one team already has 5 people on it, thus all new people must go on the other team
                   if (tracker == 5)
                    {
                        team[j] = 1;
                    }
                    if (tracker == -5)
                    {
                        team[j] = 2;
                    }
                }
                // If person 1 and 2 are on the same team, increment count, which counts the number of times they're on the same team
                if (team[1] == team[2])
                {
                    count++;
                }
                
            }
            // write out count/n, displaying the % of the time two people are on the same team
            Console.WriteLine("you have " + count +"/"+ n + " chance of being on the same team");

            // This line writes out the percent in a nicer way, if the number of trials isn't 100 and thus a double is needed 
            Console.WriteLine(Convert.ToDouble(count)/ Convert.ToDouble(n) * 100 + "% chance");
            Console.ReadKey();
        }
    }
}
