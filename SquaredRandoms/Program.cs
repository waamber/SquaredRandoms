using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> randomList = new List<int>();
            List<int> squaredList = new List<int>();

            for(int i = 0; i < 20; i++)
            {
                randomList.Add(random.Next(1, 50));
            }

            foreach(int num in randomList)
            {
                Console.WriteLine($"Random Number: {num}");
                int squaredNum = num * num;
                squaredList.Add(squaredNum);
            }

            foreach (int sqNum in squaredList.ToList()) //.ToList makes temp copy of list bc you cannot remove from list while iterating over it.
            {
                if(sqNum % 2 == 0)
                {
                    Console.WriteLine($"Squared Number: {sqNum}");
                }
                else
                {
                    squaredList.Remove(sqNum);
                } 
            }
    
            Console.ReadKey();
        }
    }
}
