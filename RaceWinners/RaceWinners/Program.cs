using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RaceWinners
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DataService ds = new DataService();
 
            // Asynchronously retrieve the group (class) data
            var data = await ds.GetGroupRanksAsync();
            var num = 0;
            Console.WriteLine("");
            Console.WriteLine("Greatest Number of Students?");
           
            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);
                
                
                Console.WriteLine($"{data[i].Name} Students: <{data[i].Count}>");

            }
            for (int l = 0; l < 4; l++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (data[l].Count > data[j].Count)
                    {
                        num += 1;
                        if (num == 3)
                        {
                            Console.WriteLine($"{data[l].Name} Has the Most Students! <{data[l].Name} + 1>");

                        }
                    }
                }
                num = 0;
            }
            Console.WriteLine("");
            //avg
            Console.WriteLine("Lowest Average?");
            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);

                Console.WriteLine($"{data[i].Name} Class Average: <{data[i].Score}>  ");
                
            }
            for (int l = 0; l < 4; l++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (data[l].Score < data[j].Score)
                    {
                        num += 1;
                        if (num == 3)
                        {
                            Console.WriteLine($"{data[l].Name} Has the Lowest Average! <{data[l].Name} + 1>");
                            
                        }
                    }
                }
                num = 0;
            }
            
            Console.WriteLine("");

            
            
            //median
            Console.WriteLine("Lowest Median?");
            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);


                Console.WriteLine($"{data[i].Name} Median of Placements: <{data[i].median}>");
                
            }
            for (int l = 0; l < 4; l++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (data[l].median < data[j].median)
                    {
                        num += 1;
                        if (num == 3)
                        {
                            Console.WriteLine($"{data[l].Name} Has the Lowest Median! <{data[l].Name} + 1>");

                        }
                    }
                }
                num = 0;
            }
            Console.WriteLine(""); 
    //top ten        
            Console.WriteLine("Students in the Top Ten?");
            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);


                Console.WriteLine($"{data[i].Name} top 10 <{data[i].ten}>");
                
            }
            Console.WriteLine("Class B and D have the most in top 10! <Class B and D + 1>");
            
            Console.WriteLine("");
    //top three                
            Console.WriteLine("Students in the Top Three?");
            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);


                Console.WriteLine($"{data[i].Name} top 3 <{data[i].three}>");
                
            }
            for (int l = 0; l < 4; l++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (data[l].median > data[j].median)
                    {
                        num += 1;
                        if (num == 3)
                        {
                            Console.WriteLine($"{data[l].Name} Has the Most in Top 3! <{data[l].Name} + 1>");

                        }
                    }
                }
                num = 0;
            }
            Console.WriteLine("");
            Console.WriteLine("Class A - 1 Point");
            Console.WriteLine("Class B - 2 Point");
            Console.WriteLine("Class C - 2 Point");
            Console.WriteLine("Class D - 1 Point");
            Console.WriteLine("");
            Console.WriteLine("0 OR 1 RANDOM NUMBER TIEBREAKER!");
            var rand = new Random();
            int winner = rand.Next(2);
            Console.WriteLine("The Number is " + winner);
            if (winner == 0)
            {
                
                Console.WriteLine("Class B is the Winner");
            }
            else{
                
                Console.WriteLine("Class C is the Winner");
            }
        }
    }
}