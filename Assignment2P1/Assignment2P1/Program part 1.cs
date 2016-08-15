using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int count = 0;
            int tracker;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                tracker = 0; 
                
                int[] team = new int[10];
                for (int j = 0; j< 10; j++)
                {
                   int choice = rand.Next(1,3);
                   if (choice == 1)
                    {
                        team[j] = 1;
                        tracker--;
                    }

                   if (choice == 2)
                    {
                        team[j] = 2;
                        tracker++;
                    }
                   if (tracker == 5)
                    {
                        team[j] = 1;
                    }
                    if (tracker == -5)
                    {
                        team[j] = 2;
                    }
                }
                if (team[1] == team[2])
                {
                    count++;
                }
                
            }
        
            Console.WriteLine("you have " + count +"/"+ n + "chance of being on the same team");

            Console.WriteLine(Convert.ToDouble(count)/ Convert.ToDouble(n) + "% chance");
            Console.ReadKey();
        }
    }
}
