using System;
using System.Collections.Generic;
using System.Linq;

namespace RaceWinners.Models
{
    /// <summary>
    /// Stores all the data associated with a group of runners
    /// </summary>
    public class Group
    {
        // Name of group
        public string Name { get; set; }
        private int Counter = 0;
        private int Best = 0;
        /// <summary>
        /// Each spot in the list represents the overall rank of finish place in this group
        /// (not the overall race).  So if index 0 contains a 4, then the first runner in this
        /// group placed 4th overall.  
        /// </summary>
        public List<int> Ranks { get; set; }

        public double Score
        {
            get { 
                return Math.Round(Ranks.Average(), 1);
            }
        }

        public int Count
        {
            
            get { return Ranks.Count(); }
            
        }

        
        public int median
        {
            get
            {
                if (Ranks.Count() % 2 != 0)
                {
                    return  Ranks[Ranks.Count()/2];
                }
                else
                {
                    int x = (Ranks[Ranks.Count() / 2]) + (Ranks[Ranks.Count() / 2 + 1]);
                    if (x % 2 != 0)
                    {
                        return x / 2 + 1;
                    }
                    else
                    {
                        return x / 2;
                    }
                }
            }

        }

        public int ten
        {
            //if list <= 10 counter + 1
            get
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Ranks[i] <= 10)
                    {
                        Counter++;
                        
                    }
                }
                return Counter;
            }
        }
        public int three
        {
            //if list <= 3 counter + 1
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Ranks[i] <= 3)
                    {
                        Best++;
                        
                    }
                }
                return Best;
            }
        }
        
    }

}